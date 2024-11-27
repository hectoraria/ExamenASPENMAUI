using ExamenASPENMAUI.Models;
using ExamenASPENMAUI.ViewModels.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenASPENMAUI.ViewModels
{
    [QueryProperty(nameof(CandidatoDetalles), "Candidato")]
    public class DetallesVM: INotifyPropertyChanged
    {


        #region atributos
        private DelegateCommand volverCommand;

        private clsCandidatoConEdad candidatoDetalles;

        #endregion

        #region propiedades

        public clsCandidatoConEdad CandidatoDetalles
        {
            get { return candidatoDetalles; }
            set
            {
                candidatoDetalles = value; NotifyPropertyChanged("CandidatoDetalles");
            }
        }

        public DelegateCommand VolverCommand
        {
            get { return volverCommand; }
        }

        public DetallesVM()
        {
            volverCommand = new DelegateCommand(VolverCommandExecute);
        }



        #endregion
        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private async void VolverCommandExecute()
        {
            await Shell.Current.GoToAsync("///MainPage");
        }

        public bool VolverCommandCanExecute()
        {
            bool res = false;

            if (CandidatoDetalles != null)
            {
                res = true;
            }

            return res;
        }
    }
}
