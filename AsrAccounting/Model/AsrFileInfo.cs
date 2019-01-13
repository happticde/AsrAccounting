using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrAccounting.Model {
    public class AsrFileInfo : INotifyPropertyChanged {
        private long fileLength;

        public long FileLength {
            get { return fileLength; }
            set {
                fileLength = value;
                OnPropertyChanged("FileLength");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
