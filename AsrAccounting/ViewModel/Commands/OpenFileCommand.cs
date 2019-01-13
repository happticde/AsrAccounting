using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AsrAccounting.ViewModel.Commands {
    public class OpenFileCommand : ICommand {
        private const string FILTER = "ASR Dateien (*.asr)|*.asr";

        public AsrVM AsrVM { get; set; }

        public event EventHandler CanExecuteChanged;

        public OpenFileCommand(AsrVM asrVM) {
            AsrVM = asrVM;
        }

        public bool CanExecute(object parameter) {
            return true;
        }

        public void Execute(object parameter) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = FILTER
            };

            if (openFileDialog.ShowDialog() == true) {
                AsrVM.LoadFile(openFileDialog.FileName);
            }
        }
    }
}
