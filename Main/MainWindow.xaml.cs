using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool FastImageCompare(Bitmap firstImage, Bitmap secondImage)
        {
            MemoryStream memoryStream = new MemoryStream();
            //將firstImage存入記憶體
            firstImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //取得firstImage的Base64雜湊值
            String firstBase64 = Convert.ToBase64String(memoryStream.ToArray());

            memoryStream = new MemoryStream();
            //將secondImage存入記憶體
            secondImage.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //取得secondImage的Base64雜湊值
            String secondBase64 = Convert.ToBase64String(memoryStream.ToArray());
            //比較firstImage與secondImage的Base64雜湊值
            if (firstBase64.Equals(secondBase64))
                return true;
            else
                return false;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TargetImagePathButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog objFileDialog = new System.Windows.Forms.OpenFileDialog();

            objFileDialog.Title = "請選取目標 Image 檔案";
            objFileDialog.InitialDirectory = "C:\\";
            if (objFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.TargetImagePathTextBox.Text = objFileDialog.FileName;
                this.TargetImage.Source = this.LoadImage(this.TargetImagePathTextBox.Text);
            }
            else
            {

            }
        }

        private void CompareImagePathButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog objFileDialog = new System.Windows.Forms.OpenFileDialog();

            objFileDialog.Title = "請選取目標 Image 檔案";
            objFileDialog.InitialDirectory = "C:\\";
            if (objFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.CompareImagePathTextBox.Text = objFileDialog.FileName;
                this.ComareImage.Source = this.LoadImage(this.CompareImagePathTextBox.Text);
            }
            else
            {

            }
        }

        private void CompareImageButton_Click(object sender, RoutedEventArgs e)
        {
            Bitmap objTarget = new Bitmap(TargetImagePathTextBox.Text);
            Bitmap objComare = new Bitmap(CompareImagePathTextBox.Text);
            if (FastImageCompare(objTarget, objComare))
            {
                MessageBox.Show("圖片一致");
            }
            else
            {
                MessageBox.Show("不一致");
            }
        }

        private BitmapImage LoadImage(string pi_sImagePath)
        {
            BitmapImage objReturn = new BitmapImage();

            objReturn.BeginInit();
            objReturn.UriSource = new Uri(pi_sImagePath);
            objReturn.EndInit();

            return objReturn;
        }

        private void WatermarkTargetImagePathButton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog objFileDialog = new System.Windows.Forms.OpenFileDialog();

            objFileDialog.Title = "請選取目標 Image 檔案";
            objFileDialog.InitialDirectory = "C:\\";
            if (objFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.WartermarkTargetImagePathTextBox.Text = objFileDialog.FileName;
                this.WartermarkTargetImage.Source = this.LoadImage(this.WartermarkTargetImagePathTextBox.Text);
            }
        }

        private void WatermarkImageButton_Click(object sender, RoutedEventArgs e)
        {
            // 建立一個 Bitmap
            Bitmap objTargetImage = new Bitmap(WartermarkTargetImagePathTextBox.Text);

            // 取得浮水印文字內容及其大小、顯示位置
            string sWaterMark = "樣本";
            int FontSize = ((objTargetImage.Width) / (sWaterMark.Length * 3));
            int x = objTargetImage.Width / 2;
            int y = (objTargetImage.Height / 2) - (FontSize * 3 / 2);

            // 字體樣式
            StringFormat DrawFormat = new StringFormat();

            DrawFormat.Alignment = StringAlignment.Center;
            DrawFormat.FormatFlags = StringFormatFlags.NoWrap;

            // 把字串畫到圖片中
            Graphics objWatermarkGraphics = Graphics.FromImage(objTargetImage);

            objWatermarkGraphics.DrawString(sWaterMark,
                new Font("微軟正黑體",
                FontSize, System.Drawing.FontStyle.Bold),
                new SolidBrush(Color.FromArgb(255, 0, 0, 0)), x, y, DrawFormat);

            // 把檔案進行暫存處理 --> 本例先行儲存至暫存資料匣中 (即 %temp% )
            string sTempPath = string.Format("{0}\\{1}.jpg", System.IO.Path.GetTempPath(), DateTime.Now.ToString("yyMMdd-hhmmss"));

            objTargetImage.Save(sTempPath);

            // 把剛才加上浮水印的檔案顯示在 pictureBox2 中
            this.WartermarkPreviewImage.Source = this.LoadImage(sTempPath);

            if (objWatermarkGraphics != null)
            {
                objWatermarkGraphics.Dispose();
            }
        }
    }
}
