using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace qlSieuThi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string thongbao;
            if (txtUserName.Text == "banhang" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(BanHang));
            }
            else if (txtUserName.Text == "kho" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(Kho));
            }
            else if (txtUserName.Text == "nhaphang" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(NhapHang));
            }
            else if (txtUserName.Text == "kiemke" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(KiemKeHangHoa));
            }
            else if (txtUserName.Text == "thongke" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(ThongKe));
            }
            else if (txtUserName.Text == "quanli" && txtPassword.Password == "")
            {
                this.Frame.Navigate(typeof(QuanLy));
            }
            else
            {
                thongbao = "Tài khoản hoặc mật không hợp lệ.";
                MessageDialog dl = new MessageDialog(thongbao);
                dl.ShowAsync();
            }
        }
    }
}
