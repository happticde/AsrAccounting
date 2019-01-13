using AsrAccounting.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsrAccounting.ViewModel {
    public class AsrVM {
        public ExitCommand ExitCommand { get; set; }

        public AsrVM() {
            ExitCommand = new ExitCommand();
        }
    }
}
