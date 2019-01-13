using AsrAccounting.ViewModel.Commands;
using AsrAccounting.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AsrAccounting.ViewModel {
    public class AsrVM {
        public AsrFileInfo AsrFileInfo { get; set; }
        public ExitCommand ExitCommand { get; set; }
        public OpenFileCommand OpenFileCommand { get; set; }

        public ObservableCollection<Customer> Customers { get; set; }

        public AsrVM() {
            AsrFileInfo = new AsrFileInfo();
            ExitCommand = new ExitCommand();
            OpenFileCommand = new OpenFileCommand(this);

            Customers = new ObservableCollection<Customer>();
        }

        public void LoadFile(string fileName) {
            FileStream fileStream = File.Open(fileName, FileMode.Open);

            if(fileStream != null) {
                AsrFileInfo.FileLength = fileStream.Length;
                fileStream.Close();
            }
        }
    }
}
