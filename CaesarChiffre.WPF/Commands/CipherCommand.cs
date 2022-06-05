using CaesarChiffre.WPF.Models;
using CaesarChiffre.WPF.ViewModels;
using System;
using System.Windows.Input;

namespace CaesarChiffre.WPF.Commands
{
    public class CipherCommand : ICommand
    {
        private readonly ChiffreViewModel _chiffreViewModel;
        private readonly CaesarChiffreModel _caesarChiffreModel;

        public CipherCommand(ChiffreViewModel chiffreViewModel, CaesarChiffreModel caesarChiffreModel)
        {
            _chiffreViewModel = chiffreViewModel;
            _caesarChiffreModel = caesarChiffreModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            try
            {
                int schlüssel = Int32.Parse(_chiffreViewModel.CaesarKey);
                if(_chiffreViewModel.Modus)
                {
                    _chiffreViewModel.OutputText = _caesarChiffreModel.CaesarDecrypt(_chiffreViewModel.InputText, schlüssel);
                } else
                {
                    _chiffreViewModel.OutputText = _caesarChiffreModel.CaesarEncrypt(_chiffreViewModel.InputText, schlüssel);
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}
