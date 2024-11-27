using BL;
using ENT;
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
    public class clsListadosMisionesCandidatosVM : INotifyPropertyChanged
    {

        #region Atributos

        private List<clsMision> listadoMisiones;
        private List<clsCandidato> listadoCandidatos;
        private List<clsCandidatoConEdad> listadoCandidatosConEdad;
        private clsMision misionSeleccionada;
        private clsCandidato candidatoSeleccionado;
        private DelegateCommand misionSeleccionarCommand;
        private DelegateCommand detallesCommand;
        #endregion

        #region Propiedades

        public List<clsCandidatoConEdad> ListadoCandidatosConEdad
        {
            get { return listadoCandidatosConEdad;}
        }
        public List<clsMision> ListadoMisiones
        {
            get { return listadoMisiones; }
        }

        public clsMision MisionSeleccionada
        {
            get { return misionSeleccionada; }
            set { misionSeleccionada = value;
                NotifyPropertyChanged("MisionSeleccionada");
                listadoMisiones = clsListadosBL.obtenerListaCompletaMisionesBL();
                listadoCandidatos = clsListadosBL.obtenerListaCompletaCandidatosBL(misionSeleccionada.Dificultad);
                listadoCandidatosConEdad = new List<clsCandidatoConEdad>();
                foreach (clsCandidato c in listadoCandidatos)
                {
                    clsCandidatoConEdad candidatoEdad = new clsCandidatoConEdad(c);
                    listadoCandidatosConEdad.Add(candidatoEdad);
                }
                NotifyPropertyChanged("ListadoCandidatosConEdad");
            }
        }

        public clsCandidato CandidatoSeleccionado
        {
            get { return candidatoSeleccionado; }
            set { candidatoSeleccionado = value; }
        }

        public DelegateCommand MisionSeleccionarCommand
        {
            get { return misionSeleccionarCommand; }
        }

        public DelegateCommand DetallesCommand
        {
            get { return detallesCommand; }
        }

        #endregion


        #region Constructores
        public clsListadosMisionesCandidatosVM()
        {
            listadoMisiones = clsListadosBL.obtenerListaCompletaMisionesBL();
            misionSeleccionarCommand = new DelegateCommand(misionSeleccionarCommandExecute);
            detallesCommand = new DelegateCommand(detallesCommandExecute);
        }
        
        #endregion

        #region Commands
        private async void misionSeleccionarCommandExecute()
        {

        }

        private async void detallesCommandExecute()
        {

        }

        #endregion
        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
