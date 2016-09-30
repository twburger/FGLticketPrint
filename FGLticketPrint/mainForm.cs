using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing.Drawing2D;
using ImageMagick;
using System.Management;


namespace FGLticketPrint
{
    public partial class MainForm : Form
    {
        string szPrinterName;
        string szImageFileName;
        string szFGLfileName;

        public MainForm()
        {
            InitializeComponent();

            // Add the available printers to the printer selection menu ToolStripComboBox
            foreach (string printer in PrinterSettings.InstalledPrinters)
                this.selectPrinterToolStripComboBox.Items.Add(printer);

            this.selectPrinterToolStripComboBox.SelectedIndex = 0;

            szPrinterName = String.Empty;
        }

        private void quitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectPrinterToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combo = (ToolStripComboBox)sender;

            PrinterSelectionTextBox.Text = szPrinterName = (string) combo.SelectedItem;

            DisplayPrinterStatus(PrinterSelectionTextBox.Text);

            // set the printer status 
            //PrinterSettings ps = new PrinterSettings();
            //ps.PrinterName = PrinterSelectionTextBox.Text;

            //bool online = false;
            //try
            //{
            //    PrintDocument printDocument = new PrintDocument();
            //    printDocument.PrinterSettings.PrinterName = PrinterSelectionTextBox.Text;
            //    online = printDocument.PrinterSettings.IsValid;
            //}
            //catch
            //{
            //    online = false;
            //}

        }

        // Display the printer status
        private void DisplayPrinterStatus(string printerName)
        {
            // Lookup arrays.
            string[] PrinterStatuses =
            {
                "0 Undefined", "1 Other", "2 Unknown", "3 Idle", "4 Printing", "5 WarmUp",
                "6 Stopped Printing", "7 Offline"  };

            string[] PrinterStates =
            {
                "0 Idle", "1 Paused", "2 Error", "3 Pending Deletion", "4 Paper Jam",
                "5 Paper Out", "6 Manual Feed", "7 Paper Problem","8 Offline", "9 IO Active", "10 Busy", "11 Printing",
                "12 Output Bin Full", "13 Not Available", "14 Waiting", "15 Processing", "16 Initialization", "17 Warming Up",
                "18 Toner Low", "19 No Toner", "20 Page Punt", "21 User Intervention Required", "22 Out of Memory",
                "23 Door Open", "24 Server_Unknown", "25 Power Save"};

            // Get a ManagementObjectSearcher for the printer.
            string query = "SELECT * FROM Win32_Printer WHERE Name='" + printerName + "'";

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

            // Get the ManagementObjectCollection representing
            // the result of the WMI query. Loop through its
            // single item. Display some of that item's properties.
            foreach (ManagementObject service in searcher.Get())
            {
                UInt32 state = (UInt32)service.Properties["PrinterState"].Value;
                UInt16 status = (UInt16)service.Properties["PrinterStatus"].Value;

                PrinterStatusTextBox.Text = "Status: "+ PrinterStatuses[status] + " State: " + PrinterStates[state];

                /*
                txtName.Text = service.Properties["Name"].Value.ToString();

                UInt32 state =
                    (UInt32)service.Properties["PrinterState"].Value;
                txtState.Text =
                    PrinterStates[state];

                UInt16 status =
                    (UInt16)service.Properties["PrinterStatus"].Value;
                txtStatus.Text = PrinterStatuses[status];

                txtDescription.Text =
                    GetPropertyValue(service.Properties["Description"]);
                txtDefault.Text =
                    GetPropertyValue(service.Properties["Default"]);
                txtHorRes.Text =
                    GetPropertyValue(service.Properties["HorizontalResolution"]);
                txtVertRes.Text =
                    GetPropertyValue(service.Properties["VerticalResolution"]);
                txtPort.Text =
                    GetPropertyValue(service.Properties["PortName"]);

                lstPaperSizes.Items.Clear();
                string[] paper_sizes =
                    (string[])service.Properties["PrinterPaperNames"].Value;
                foreach (string paper_size in paper_sizes)
                {
                    lstPaperSizes.Items.Add(paper_size);
                }

                // List the available properties.
                foreach (PropertyData data in service.Properties)
                {
                    string txt = data.Name;
                    if (data.Value != null)
                        txt += ": " + data.Value.ToString();
                    Console.WriteLine(txt);
                }
                */
            }
        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Select a BMP or PCX file that is one bit (black and white) in depth
            // Create an instance of the open file dialog box.
            OpenFileDialog openImageFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openImageFileDialog.Filter = "Bitmap Files (.bmp)|*.bmp|PCX Files (.pcx)|*.pcx|All Files (*.*)|*.*";
            openImageFileDialog.FilterIndex = 1;

            openImageFileDialog.Multiselect = true;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClicked = openImageFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (userClicked == DialogResult.OK)
            {
                Image FGLimage;

                // Save the image file name
                szImageFileName = openImageFileDialog.FileName;

                // read a PCX and convert it to BMP, save it and load the bitmap
                if (0 == string.Compare(".pcx", Path.GetExtension(szImageFileName), true))
                {
                    // use MagickImage library to read a PCX file
                    // https://magick.codeplex.com/wikipage?title=Convert%20image

                    using (MagickImage image = new MagickImage(szImageFileName))
                    {
                        FGLimage = image.ToBitmap();  // Copy the bitmap to be displayed

                        // write it back as a BMP file
                        string szfilename = szImageFileName + ".BMP";

                        // Do not overwrite an existing file
                        if (!File.Exists(szfilename))
                            image.Write(szfilename);
                    }
                }
                else
                {
                    // Place image in the pictureBox
                    //Image FGLimage = Image.FromFile(szImageName);
                    //Image FGLimage;
                    FileStream myStream = new FileStream(szImageFileName, FileMode.Open);

                    try
                    {
                        FGLimage = Image.FromStream(myStream);
                        //Size s = FGLimage.Size;
                    }
                    catch
                    {
                        // display error dialog
                        MessageBox.Show("The file selected could not be opened or processed",
                            "Image Error: " + FGL_utility.EllipsisString(szImageFileName), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        szImageFileName = string.Empty;
                        return;
                    }
                    finally
                    {
                        myStream.Close();
                        myStream.Dispose();
                    }
                }

                FGLimageNameTextBox.Text = FGL_utility.EllipsisString(szImageFileName);

                // resize the bitmap to fit the picturebox display
                Image newImage = new Bitmap(FGLpictureBox.Width, FGLpictureBox.Height);
                Graphics graphics = Graphics.FromImage(newImage);
                //graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                //graphics.DrawImage(FGLimage, new Rectangle(0, 0, FGLpictureBox.Width, FGLpictureBox.Height));
                graphics.DrawImage(FGLimage, 0, 0, FGLpictureBox.Width, FGLpictureBox.Height);

                FGLpictureBox.Image = newImage;

                // release image resources
                //newImage.Dispose();
                FGLimage.Dispose();
            }
        }

        private void selectFGLCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Select a BMP or PCX file that is one bit (black and white) in depth
            // Create an instance of the open file dialog box.
            OpenFileDialog openFGLtextFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFGLtextFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFGLtextFileDialog.FilterIndex = 1;
            //openFGLtextFileDialog.RestoreDirectory = true;
            openFGLtextFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClicked = openFGLtextFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (userClicked == DialogResult.OK)
            {
                try
                {
                    // Save the image file name
                    szFGLfileName = openFGLtextFileDialog.FileName;
                }
                catch
                {
                    // display error dialog
                    MessageBox.Show("The file selected could not be opened or processed",
                        "FGL Code Text File Error: " + FGL_utility.EllipsisString(szFGLfileName), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    szFGLfileName = string.Empty;
                    return;
                }
                finally
                {
                    // read the test and place it in the dialog
                    string szText = File.ReadAllText(szFGLfileName);
                    FGLcodeTextBox.Text = szText;
                    FGLCodeFileNametextBox.Text = FGL_utility.EllipsisString(szFGLfileName);
                }
            }
        }

        /// <summary>
        /// Tells Windows that we handled a non-numeric key so it will ignore anything not
        /// 0 through 9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SaveFGLcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the path to the code text file and write the FGL file text to it.
            
            SaveFileDialog FGLcodeSaveFileDialog = new SaveFileDialog();

            FGLcodeSaveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            FGLcodeSaveFileDialog.FilterIndex = 1;
            //FGLcodeSaveFileDialog.RestoreDirectory = true;

            if (FGLcodeSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string FGLtextfile = FGLcodeSaveFileDialog.FileName;
                try
                {
                    File.WriteAllText(FGLtextfile, FGLcodeTextBox.Text);
                    // Save the image file name
                    szFGLfileName = FGLcodeSaveFileDialog.FileName;
                }
                catch
                {
                    // display error dialog
                    MessageBox.Show("The file selected could not be saved",
                        "FGL Code Text File Error: " + FGL_utility.EllipsisString(szFGLfileName), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    szFGLfileName = string.Empty;
                    return;
                }
                finally
                {
                    szFGLfileName = FGLtextfile;
                    FGLCodeFileNametextBox.Text = FGL_utility.EllipsisString(szFGLfileName);
                }
            }
        }
    }

    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "My C#.NET RAW Document";
            di.pDataType = "RAW";

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
            return bSuccess;
        }
        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }

    public static class FGL_utility
    {

        public static string EllipsisString(this string rawString, int maxLength = 30, char delimiter = '\\')
        {
            maxLength -= 3; //account for delimiter spacing

            if (rawString.Length <= maxLength)
            {
                return rawString;
            }

            string final = rawString;
            List<string> parts;

            int loops = 0;
            while (loops++ < 100)
            {
                parts = rawString.Split(delimiter).ToList();
                parts.RemoveRange(parts.Count - 1 - loops, loops);
                if (parts.Count == 1)
                {
                    return parts.Last();
                }

                parts.Insert(parts.Count - 1, "...");
                final = string.Join(delimiter.ToString(), parts);
                if (final.Length < maxLength)
                {
                    return final;
                }
            }

            return rawString.Split(delimiter).ToList().Last();
        }
    }


}
