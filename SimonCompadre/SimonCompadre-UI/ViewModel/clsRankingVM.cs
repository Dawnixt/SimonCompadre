using SimonCompadre_BL.Lists;
using SimonCompadre_Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SimonCompadre_UI.ViewModel
{
    public class clsRankingVM
    {
        private ObservableCollection<clsPuntuaciones> _listadoPuntuaciones;

        public clsRankingVM()
        {

            try
            {
                clsListadoPuntuacionesBL puntuacionesBL = new clsListadoPuntuacionesBL();
                _listadoPuntuaciones = new ObservableCollection<clsPuntuaciones>(puntuacionesBL.obtenerPuntuacionesBL());
            }
            catch (SqlException)
            {
                this.mensajeError();
            }

            
        }

        public ObservableCollection<clsPuntuaciones> ListadoPuntuaciones
        {
            get
            {
                return _listadoPuntuaciones;
            }
            set
            {
                _listadoPuntuaciones = value;
            }
        }

        /// <summary>
        /// Este metodo nos mostrara un mensaje de error 
        /// </summary>
        public async void mensajeError()
        {

            ContentDialog mensaje = new ContentDialog();
            Frame frame = Window.Current.Content as Frame;

            mensaje.Title = "Error";
            mensaje.Content = "Ha ocurrido un error vuelva a intertarlo mas tarde";
            mensaje.PrimaryButtonText = "Salir";

            ContentDialogResult finale = await mensaje.ShowAsync();

        }

    }
}
