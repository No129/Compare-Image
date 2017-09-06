using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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


    }
}
