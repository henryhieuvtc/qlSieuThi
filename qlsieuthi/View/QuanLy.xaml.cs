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
            if (SplitView.IsPaneOpen)
            {
                dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                dsDonHang.Width = Window.Current.Bounds.Width - 220;
                dsTonkho.Width = Window.Current.Bounds.Width - 220;
                dshanghoataiquay.Width = Window.Current.Bounds.Width - 220;
                dsNhanvien.Width = Window.Current.Bounds.Width - 220;
                dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 220;
                dsKHtiemnang.Width = Window.Current.Bounds.Width - 220;
                dsQLHoadon.Width = Window.Current.Bounds.Width - 220;
                dsQLNhacungcap.Width = Window.Current.Bounds.Width - 220;
                dsQLsanpham.Width = Window.Current.Bounds.Width - 220;
                dsKhuyenmai.Width = Window.Current.Bounds.Width - 220;
            }
            else
            {
                dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                dsDonHang.Width = Window.Current.Bounds.Width - 68;
                dsTonkho.Width = Window.Current.Bounds.Width - 68;
                dshanghoataiquay.Width = Window.Current.Bounds.Width - 68;
                dsNhanvien.Width = Window.Current.Bounds.Width - 68;
                dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 68;
                dsKHtiemnang.Width = Window.Current.Bounds.Width - 68;
                dsQLHoadon.Width = Window.Current.Bounds.Width - 68;
                dsQLNhacungcap.Width = Window.Current.Bounds.Width - 68;
                dsQLsanpham.Width = Window.Current.Bounds.Width - 68;
                dsKhuyenmai.Width = Window.Current.Bounds.Width - 68;
            }
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
                dsHoaDon.Height = Window.Current.Bounds.Height - 225;
                PPThongkebaocao.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                txtTongTien.Width = dsHoaDon.Width;
                PPThongkebaocaoIsOpen = true;
                PPLichSu.IsOpen = false;
                PPLichsuIsOpen = false;
                PPGuiYeuCau.IsOpen = false;
                PPGuiyeucauIsOpen = false;

                PPQuanli.IsOpen = false;
                PPQuanliIsOpen = false;
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
                PPLichSu.IsOpen = false;
                PPLichsuIsOpen = false;
                PPThongkebaocao.IsOpen = false;
                PPThongkebaocaoIsOpen = false;
                PPGuiYeuCau.IsOpen = false;
                PPGuiyeucauIsOpen = false;

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
                dsTonkho.Height = Window.Current.Bounds.Height - 160;
                PPTonkho.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsTonkho.Width = Window.Current.Bounds.Width - 220;
                }
                else dsTonkho.Width = Window.Current.Bounds.Width - 68;

                PPTonkhoIsOpen = true;

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
                dshanghoataiquay.Height = Window.Current.Bounds.Height - 160;
                PPHanghoataiquay.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dshanghoataiquay.Width = Window.Current.Bounds.Width - 220;
                }
                else dshanghoataiquay.Width = Window.Current.Bounds.Width - 68;

                PPHanghoataiquayIsOpen = true;

                PPTonkho.IsOpen = false;
                PPTonkhoIsOpen = false;
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
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PPQuanli.IsOpen = true;
            PPQuanliIsOpen = true;
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
                PPLichSu.IsOpen = false;
                PPLichsuIsOpen = false;
                PPThongkebaocao.IsOpen = false;
                PPThongkebaocaoIsOpen = false;

                PPQuanli.IsOpen = false;
                PPQuanliIsOpen = false;
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
                dsDonHang.Height = Window.Current.Bounds.Height - 90;
                PPLichSu.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsDonHang.Width = Window.Current.Bounds.Width - 220;
                }
                else dsDonHang.Width = Window.Current.Bounds.Width - 68;
                BannerLS.Width = dsDonHang.Width;
                PPLichsuIsOpen = true;
                PPThongkebaocao.IsOpen = false;
                PPThongkebaocaoIsOpen = false;
                PPGuiYeuCau.IsOpen = false;
                PPGuiyeucauIsOpen = false;

                PPQuanli.IsOpen = false;
                PPQuanliIsOpen = false;
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
                dsNhanvien.Height = Window.Current.Bounds.Height - 160;
                PPNhanvien.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsNhanvien.Width = Window.Current.Bounds.Width - 220;
                }
                else dsNhanvien.Width = Window.Current.Bounds.Width - 68;
                PPNhanvienIsOpen = true;

                PPTonkho.IsOpen = false;
                PPTonkhoIsOpen = false;
                PPHanghoataiquay.IsOpen = false;
                PPHanghoataiquayIsOpen = false;
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

                PPTonkho.IsOpen = false;
                PPTonkhoIsOpen = false;
                PPHanghoataiquay.IsOpen = false;
                PPHanghoataiquayIsOpen = false;
                PPNhanvien.IsOpen = false;
                PPNhanvienIsOpen = false;
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
                dsKHthuongxuyen.Height = Window.Current.Bounds.Height - 160;
                PPKHthuongxuyen.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKHthuongxuyen.Width = Window.Current.Bounds.Width - 68;
                PPKHthuongxuyenIsOpen = true;

                PPTonkho.IsOpen = false;
                PPTonkhoIsOpen = false;
                PPHanghoataiquay.IsOpen = false;
                PPHanghoataiquayIsOpen = false;
                PPNhanvien.IsOpen = false;
                PPNhanvienIsOpen = false;
                PPThemNV.IsOpen = false;
                PPThemNVIsOpen = false;
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
                dsKHtiemnang.Height = Window.Current.Bounds.Height - 160;
                PPKHtiemnang.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKHtiemnang.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKHtiemnang.Width = Window.Current.Bounds.Width - 68;
                PPKHtiemnangIsOpen = true;

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
                PPHoadon.IsOpen = false;
                PPHoadonIsOpen = false;
                PPNhacungcap.IsOpen = false;
                PPNhacungcapIsOpen = false;
                PPSanpham.IsOpen = false;
                PPSanphamIsOpen = false;
                PPKhuyenmai.IsOpen = false;
                PPKhuyenmaiIsOpen = false;
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
                dsQLHoadon.Height = Window.Current.Bounds.Height - 160;
                PPHoadon.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLHoadon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLHoadon.Width = Window.Current.Bounds.Width - 68;
                PPHoadonIsOpen = true;

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
                PPNhacungcap.IsOpen = false;
                PPNhacungcapIsOpen = false;
                PPSanpham.IsOpen = false;
                PPSanphamIsOpen = false;
                PPKhuyenmai.IsOpen = false;
                PPKhuyenmaiIsOpen = false;
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
                dsQLNhacungcap.Height = Window.Current.Bounds.Height - 160;
                PPNhacungcap.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLNhacungcap.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLNhacungcap.Width = Window.Current.Bounds.Width - 68;
                PPNhacungcapIsOpen = true;

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
                PPSanpham.IsOpen = false;
                PPSanphamIsOpen = false;
                PPKhuyenmai.IsOpen = false;
                PPKhuyenmaiIsOpen = false;
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
                dsQLsanpham.Height = Window.Current.Bounds.Height - 160;
                PPSanpham.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsQLsanpham.Width = Window.Current.Bounds.Width - 220;
                }
                else dsQLsanpham.Width = Window.Current.Bounds.Width - 68;
                PPSanphamIsOpen = true;

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
                PPKhuyenmai.IsOpen = false;
                PPKhuyenmaiIsOpen = false;
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
                dsKhuyenmai.Height = Window.Current.Bounds.Height - 200;
                PPKhuyenmai.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsKhuyenmai.Width = Window.Current.Bounds.Width - 220;
                }
                else dsKhuyenmai.Width = Window.Current.Bounds.Width - 68;
                PPKhuyenmaiIsOpen = true;

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
            }
        }
    }
}
