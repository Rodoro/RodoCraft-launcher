using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace RodoCraft
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WindowMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        //private async void acceptButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Действие выполнено");

        //    // This session variable is the result of logging in and is used in MLaunchOption, in the Launch part below.
        //    var session = MSession.GetOfflineSession("Rodoro");

        //    System.Net.ServicePointManager.DefaultConnectionLimit = 4;

        //    //var path = new MinecraftPath("game_directory_path");
        //    var path = new MinecraftPath(); // use default directory

        //    var launcher = new CMLauncher(path);

        //    // show launch progress to console
        //    launcher.FileChanged += (e) =>
        //    {
        //        Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
        //    };
        //    launcher.ProgressChanged += (s, e) =>
        //    {
        //        Console.WriteLine("{0}%", e.ProgressPercentage);
        //    };

        //    var versions = await launcher.GetAllVersionsAsync();
        //    foreach (var item in versions)
        //    {
        //        // show all version names
        //        // use this version name in CreateProcessAsync method.
        //        Console.WriteLine(item.Name);
        //    }

        //    var launchOption = new MLaunchOption
        //    {
        //        MaximumRamMb = 1024,
        //        Session = session, // replace this with login session value. ex) Session = MSession.GetOfflineSession("hello")

        //        ScreenWidth = 1600,
        //        ScreenHeight = 900,
        //        ServerIp = "mc.dexland.org"
        //    };

        //    //var process = await launcher.CreateProcessAsync("input version name here", launchOption);
        //    var process = await launcher.CreateProcessAsync("1.19.2", launchOption); // vanilla
        //                                                                             // var process = await launcher.CreateProcessAsync("1.12.2-forge1.12.2-14.23.5.2838", launchOption); // forge
        //                                                                             // var process = await launcher.CreateProcessAsync("1.12.2-LiteLoader1.12.2"); // liteloader
        //                                                                             // var process = await launcher.CreateProcessAsync("fabric-loader-0.11.3-1.16.5") // fabric-loader

        //    process.Start();
        //}
    }
}
