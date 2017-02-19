using qlSieuThi.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace qlSieuThi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Kho : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public bool PPAddsanphamIsOpen { get; set; } = false;
        public bool PPYeucauIsOpen { get; set; } = false;
        public bool PPGuiyeucauIsOpen { get; set; } = false;
        public bool PPLichsuIsOpen { get; set; } = false;
        public Kho()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new
               SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<CHangHoa>();
        }
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
            if (PPAddsanphamIsOpen)
            {
                addSanPham();
                PPAddsanpham.IsOpen = false;
                PPAddsanphamIsOpen = false;
            }
            else
            {
                PPAddsanpham.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsHoaDon.Width = Window.Current.Bounds.Width - 220;
                }
                else dsHoaDon.Width = Window.Current.Bounds.Width - 68;
                txtTongTien.Width = dsHoaDon.Width;
                PPAddsanphamIsOpen = true;
                getSanPham();
            }
          
        }
        private void XuatSanpham_Click(object sender, RoutedEventArgs e)
        {
            if (PPYeucauIsOpen)
            {
                PPYeucau.IsOpen = false;
                PPYeucauIsOpen = false;
            }
            else
            {
                PPYeucau.IsOpen = true;
                if (SplitView.IsPaneOpen)
                {
                    dsYeucau.Width = Window.Current.Bounds.Width - 220;
                }
                else dsYeucau.Width = Window.Current.Bounds.Width - 68;
                BannerYC.Width = dsYeucau.Width;
                PPYeucauIsOpen = true;
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

        private void btnNhapsanpham_Click(object sender, RoutedEventArgs e)
        {
        }

        private void addSanPham()
        {
            string id = "1"; //get id hang hoa

            CHangHoa hanghoa = (from p in conn.Table<CHangHoa>() where p.Id == "10" select p).FirstOrDefault();
            string ten = "";
            int soluong = hanghoa.Soluong + 10;
            string congty = "";




            var s = conn.InsertOrReplace(new CHangHoa() {
                Id = id, Ten = ten, Soluong = soluong, Congty = congty
            });
        }

        private void getSanPham() {
            var query = conn.Table<CHangHoa>();
            List<CHangHoa> listHangHoa = (from p in conn.Table <CHangHoa>() select p).ToList();
            string id = "";
            string name = "";
            int soluong = 0;

            foreach (var message in query)
            {
                id = id + " " + message.Id;
                name = name + " " + message.Ten;
                soluong = message.Soluong;
            }
            txtTenNV.Text =listHangHoa[0].Id +" "+ listHangHoa[0].Soluong.ToString();
        }

    }

}
