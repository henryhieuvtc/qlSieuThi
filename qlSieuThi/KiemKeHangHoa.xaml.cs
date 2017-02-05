﻿using System;
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
    public sealed partial class KiemKeHangHoa : Page
    {
        public KiemKeHangHoa()
        {
            this.InitializeComponent();
        }
        public bool PPAddKiemkeIsOpen { get; set; } = false;
        public bool PPKiemtraIsOpen { get; set; } = false;
        public bool PPGuiyeucauIsOpen { get; set; } = false;
        public bool PPLichsuIsOpen { get; set; } = false;
        public bool PPTonkhoIsOpen { get; set; } = false;
        public bool PPHanghoataiquayIsOpen { get; set; } = false;
        public bool PPHanghoabantrongngayIsOpen { get; set; } = false;
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
            if (PPAddKiemkeIsOpen)
            {
                PPAddKiemke.IsOpen = false;
                PPAddKiemkeIsOpen = false;
            }
            else
            {
                PPAddKiemke.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                txtTongTien.Width = dsHoaDon.Width;
                PPAddKiemkeIsOpen = true;
            }
        }
        private void KiemTra_Click(object sender, RoutedEventArgs e)
        {
            if(PPKiemtraIsOpen)
            {
                PPKiemtra.IsOpen = false;
                PPKiemtraIsOpen = false;
            }
            else
            {
                PPKiemtra.IsOpen = true;
                PPKiemtraIsOpen = true;
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
        private void btnHangHoaBanTrongNgay_Click(object sender, RoutedEventArgs e)
        {
            {
                if (PPHanghoabantrongngayIsOpen)
                {
                    PPHanghoabantrongngay.IsOpen = false;
                    PPHanghoabantrongngayIsOpen = false;
                }
                else
                {
                    PPHanghoabantrongngay.IsOpen = true;
                    if (SplitView.IsPaneOpen)
                    {
                        dshanghoabantrongngay.Width = Window.Current.Bounds.Width - 220;
                    }
                    else dshanghoabantrongngay.Width = Window.Current.Bounds.Width - 68;
                    
                    PPHanghoabantrongngayIsOpen = true;
                }
            }
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PPTonkho.IsOpen = false;
            PPTonkhoIsOpen = false;
            PPHanghoataiquay.IsOpen = false;
            PPHanghoataiquayIsOpen = false;
            PPHanghoabantrongngay.IsOpen = false;
            PPHanghoabantrongngayIsOpen = false;
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
