using CaesarChiffre.WPF.Models;
using CaesarChiffre.WPF.ViewModels;
using System.Windows;

namespace CaesarChiffre.WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            CaesarChiffreModel caesarChiffreModel = new CaesarChiffreModel();
            ChiffreViewModel chiffreViewModel = new ChiffreViewModel(caesarChiffreModel);
            window.DataContext = chiffreViewModel;
            window.Show();
            base.OnStartup(e);
        }
    }
}
