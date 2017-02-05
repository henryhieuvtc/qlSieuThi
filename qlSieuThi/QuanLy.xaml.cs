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
    public sealed partial class QuanLy : Page
    {
        public QuanLy()
        {
            this.InitializeComponent();
        }
        public bool PPThongkebaocaoIsOpen { get; set; } = false;
        public bool PPQuanliIsOpen { get; set; } = false;
        public bool PPGuiyeucauIsOpen { get; set; } = false;
        public bool PPLichsuIsOpen { get; set; } = false;
        public bool PPTonkhoIsOpen { get; set; } = false;
        public bool PPHanghoataiquayIsOpen { get; set; } = false;
        public bool PPNhanvienIsOpen { get; set; } = false;
        public bool PPThemNVIsOpen { get; set; } = false;
        public bool PPKHthuongxuyenIsOpen { get; set; } = false;
        public bool PPKHtiemnangIsOpen { get; set; } = false;
        public bool PPHoadonIsOpen { get; set; } = false;
        public bool PPNhacungcapIsOpen { get; set; } = false;
        public bool PPSanphamIsOpen { get; set; } = false;
        public bool PPKhuyenmaiIsOpen { get; set; } = false;
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
            if (PPThongkebaocaoIsOpen)
            {
                PPThongkebaocao.IsOpen = false;
                PPThongkebaocaoIsOpen = false;
            }
            else
            {
                PPThongkebaocao.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                txtTongTien.Width = dsHoaDon.Width;
                PPThongkebaocaoIsOpen = true;
            }
        }
        private void KiemTra_Click(object sender, RoutedEventArgs e)
        {
            if (PPQuanliIsOpen)
            {
                PPQuanli.IsOpen = false;
                PPQuanliIsOpen = false;
            }
            else
            {
                PPQuanli.IsOpen = true;
                PPQuanliIsOpen = true;
            }
        }

        private void btnHangTonKho_Click(object sender, RoutedEventArgs e)
        {
            if (PPTonkhoIsOpen)
            {
                PPTonkho.IsOpen = false;
                PPTonkhoIsOpen = false;
            }
            else
            {
                PPTonkho.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsTonkho.Width = Window.Current.Bounds.Width - 220;
                }
                else dsTonkho.Width = Window.Current.Bounds.Width - 68;

                PPTonkhoIsOpen = true;
            }
        }

        private void btnHangHoaTaiQuay_Click(object sender, RoutedEventArgs e)
        {
            if (PPHanghoataiquayIsOpen)
            {
                PPHanghoataiquay.IsOpen = false;
                PPHanghoataiquayIsOpen = false;
            }
            else
            {
                PPHanghoataiquay.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dshanghoataiquay.Width = Window.Current.Bounds.Width - 220;
                }
                else dshanghoataiquay.Width = Window.Current.Bounds.Width - 68;

                PPHanghoataiquayIsOpen = true;
            }
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PPTonkho.IsOpen = false;
            PPTonkhoIsOpen = false;
            PPHanghoataiquay.IsOpen = false;
            PPHanghoataiquayIsOpen = false;
            PPNhanvien.IsOpen = false;
            PPNhanvienIsOpen = false;
            PPThemNV.IsOpen = false;
            PPThemNVIsOpen = false;
            PPKHthuongxuyen.IsOpen = false;
            PPKHthuongxuyenIsOpen = false;
            PPKHtiemnang.IsOpen = false;
            PPKHtiemnangIsOpen = false;
            PPHoadon.IsOpen = false;
            PPHoadonIsOpen = false;
            PPNhacungcap.IsOpen = false;
            PPNhacungcapIsOpen = false;
            PPSanpham.IsOpen = false;
            PPSanphamIsOpen = false;
            PPKhuyenmai.IsOpen = false;
            PPKhuyenmaiIsOpen = false;
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

        private void btnNV_Click(object sender, RoutedEventArgs e)
        {
            if (PPNhanvienIsOpen)
            {
                PPNhanvien.IsOpen = false;
                PPNhanvienIsOpen = false;
            }
            else
            {
                PPNhanvien.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsNhanvien.Width = Window.Current.Bounds.Width - 220;
                }
                else dsNhanvien.Width = Window.Current.Bounds.Width - 68;
                PPNhanvienIsOpen = true;
            }
        }

        private void btnThemNV_Click(object sender, RoutedEventArgs e)
        {
             if(PPThemNVIsOpen)
            {
                PPThemNV.IsOpen = false;
                PPThemNVIsOpen = false;
            }
             else
            {
                PPThemNV.IsOpen = true;
                PPThemNVIsOpen = true;
            }
        }

        private void btnKHthuongxuyen_Click(object sender, RoutedEventArgs e)
        {
            if (PPKHthuongxuyenIsOpen)
            {
                PPKHthuongxuyen.IsOpen = false;
                PPKHthuongxuyenIsOpen = false;
            }
            else
            {
                PPKHthuongxuyen.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 68;
                PPKHthuongxuyenIsOpen = true;
            }
        }

        private void btnKHtiemnang_Click(object sender, RoutedEventArgs e)
        {
            if (PPKHtiemnangIsOpen)
            {
                PPKHtiemnang.IsOpen = false;
                PPKHtiemnangIsOpen = false;
            }
            else
            {
                PPKHtiemnang.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKHtiemnang.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKHtiemnang.Width = Window.Current.Bounds.Width - 68;
                PPKHtiemnangIsOpen = true;
            }
        }

        private void btnHoaDon_Click(object sender, RoutedEventArgs e)
        {
            if (PPHoadonIsOpen)
            {
                PPHoadon.IsOpen = false;
                PPHoadonIsOpen = false;
            }
            else
            {
                PPHoadon.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLHoadon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLHoadon.Width = Window.Current.Bounds.Width - 68;
                PPHoadonIsOpen = true;
            }
        }

        private void btnNhaCungCap_Click(object sender, RoutedEventArgs e)
        {
            if (PPNhacungcapIsOpen)
            {
                PPNhacungcap.IsOpen = false;
                PPNhacungcapIsOpen = false;
            }
            else
            {
                PPNhacungcap.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLNhacungcap.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLNhacungcap.Width = Window.Current.Bounds.Width - 68;
                PPNhacungcapIsOpen = true;
            }
        }

        private void btnSanPham_Click(object sender, RoutedEventArgs e)
        {
            if (PPSanphamIsOpen)
            {
                PPSanpham.IsOpen = false;
                PPSanphamIsOpen = false;
            }
            else
            {
                PPSanpham.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLsanpham.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLsanpham.Width = Window.Current.Bounds.Width - 68;
                PPSanphamIsOpen = true;
            }
        }

        private void btnKhuyenMai_Click(object sender, RoutedEventArgs e)
        {
            if (PPKhuyenmaiIsOpen)
            {
                PPKhuyenmai.IsOpen = false;
                PPKhuyenmaiIsOpen = false;
            }
            else
            {
                PPKhuyenmai.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKhuyenmai.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKhuyenmai.Width = Window.Current.Bounds.Width - 68;
                PPKhuyenmaiIsOpen = true;
            }
        }
    }
}
