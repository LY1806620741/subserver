using subserver.controller;
using System;
using System.Collections.Generic;
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

namespace subserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Server server=new Server();
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Switchclick(object sender, RoutedEventArgs e)
        {
            if (_switch.Content.ToString() != "关闭")
            {
                this._switch.Content = "关闭";
                this.tips.Text= String.Join(",",server.GetIP().Select(ip => ip.ToString()).ToList());
            }
            else
            {
                this._switch.Content = "开始";
                this.tips.Text = "IP";
            }
        }
    }
}
