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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace qlSieuThi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ThongKe : Page
    {
        public ThongKe()
        {
            this.InitializeComponent();
        }
        public bool PPAddBaocaoIsOpen { get; set; } = false;
        public bool PPTThanghoataiquayIsOpen { get; set; } = false;
        public bool PPTThanghoatrongkhoIsOpen { get; set; } = false;
        public bool PPGuiyeucauIsOpen { get; set; } = false;
        public bool PPLichsuIsOpen { get; set; } = false;
        private void SplitViewButton_Click(object sender, RoutedEventArgs e)
        {
            SplitView.IsPaneOpen = !SplitView.IsPaneOpen;
        }
        private async void btnExit_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dl = new MessageDialog("Bạn có muốn thoát không?");
            dl.Commands.Add(new UICommand("Có") { Id = 0 });
            dl.Commands.Add(new UICommand("Không") { Id = 1 });
            var result = await dl.ShowAsync();
            if ((int)result.Id == 0)
            {
                this.Frame.Navigate(typeof(MainPage));
            }
        }

        private void AddSanpham_Click(object sender, RoutedEventArgs e)
        {
            if (PPAddBaocaoIsOpen)
            {
                PPAddBaocao.IsOpen = false;
                PPAddBaocaoIsOpen = false;
            }
            else
            {
                PPAddBaocao.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                txtTongTien.Width = dsHoaDon.Width;
                PPAddBaocaoIsOpen = true;
            }
        }
        private void XuatSanpham_Click(object sender, RoutedEventArgs e)
        {
            if (PPTThanghoataiquayIsOpen)
            {
                PPTThanghoataiquay.IsOpen = false;
                PPTThanghoataiquayIsOpen = false;
            }
            else
            {
                PPTThanghoataiquay.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHanghoataiquay.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHanghoataiquay.Width = Window.Current.Bounds.Width - 68;
                BannerHHTQ.Width = dsHanghoataiquay.Width;
                PPTThanghoataiquayIsOpen = true;
            }
        }
        private void TThanghoatrongkho_Click(object sender, RoutedEventArgs e)
        {
            if (PPTThanghoatrongkhoIsOpen)
            {
                PPTThanghoatrongkho.IsOpen = false;
                PPTThanghoatrongkhoIsOpen = false;
            }
            else
            {
                PPTThanghoatrongkho.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHanghoatrongkho.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHanghoatrongkho.Width = Window.Current.Bounds.Width - 68;
                BannerHHTK.Width = dsHanghoatrongkho.Width;
                PPTThanghoatrongkhoIsOpen = true;
            }
        }
        private void guiyeucau_Click(object sender, RoutedEventArgs e)
        {
            if (PPGuiyeucauIsOpen)
            {
                PPGuiYeuCau.IsOpen = false;
                PPGuiyeucauIsOpen = false;
            }
            else
            {
                PPGuiYeuCau.IsOpen = true;
                PPGuiyeucauIsOpen = true;
            }
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog dl = new MessageDialog("Bạn có chắc bạn muốn bỏ bản nháp này?");
            dl.Commands.Add(new UICommand("Bỏ") { Id = 0 });
            dl.Commands.Add(new UICommand("Hủy Bỏ") { Id = 1 });
            var result = await dl.ShowAsync();
            if ((int)result.Id == 0)
            {
                PPGuiYeuCau.IsOpen = false;
                PPGuiyeucauIsOpen = false;
                txtChuDe.Text = "";
                txtNoiDung.Text = "";
            }
        }

        private void Lichsu_Click(object sender, RoutedEventArgs e)
        {
            if (PPLichsuIsOpen)
            {
                PPLichSu.IsOpen = false;
                PPLichsuIsOpen = false;
            }
            else
            {
                PPLichSu.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsDonHang.Width = Window.Current.Bounds.Width - 220;
                }
                else dsDonHang.Width = Window.Current.Bounds.Width - 68;
                BannerLS.Width = dsDonHang.Width;
                PPLichsuIsOpen = true;
            }
        }

    }
}
