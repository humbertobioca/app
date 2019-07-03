using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HBSSCAN.Service;
using MySql.Data.MySqlClient;
using Xamarin.Forms;

namespace HBSSCAN
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_OnClicked(object sender, EventArgs e) => await OpenScan();

        //void consultHash(string hash)
        //{
        //    //MySqlConnection mySqlConnection = new MySqlConnection("Server=tcp:biocasites.database.windows.net,1433;Initial Catalog=BaseBD;Persist Security Info=False;User ID=hbioca;Password=Amor!123;");
        //    try {
        //       // if (mySqlConnection.State == System.Data.ConnectionState.Closed) {

        //          //  mySqlConnection.Open();
        //            MySqlCommand cmd = new MySqlCommand(
        //                "SELECT * FROM PARTICIPANTES WHERE PPTOKEN = @PPTOKEN", mySqlConnection
        //                );
        //            cmd.Parameters.AddWithValue("@PPTOKEN",hash);
        //            cmd.ExecuteNonQuery();

        //            DisplayAlert("Alert", "CONECTADO", "OK");

        //        }
        //    }
        //    catch (MySqlException erro)
        //    {
        //        DisplayAlert("Alert", Convert.ToString(erro), "OK");
        //    }
        //    finally
        //    {
        //        mySqlConnection.Close();
        //    }
        //}

        private async Task OpenScan()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {
                // Sua logica.
                var hash = result;
                //consultHash(hash);
            }
        }
    }
}
