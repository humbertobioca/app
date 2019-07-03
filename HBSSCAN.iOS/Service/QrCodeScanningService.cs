

using System.Threading.Tasks;
using HBSSCAN.Service;
using Xamarin.Forms;
using ZXing.Mobile;


[assembly: Dependency(typeof(HBSSCAN.iOS.Service.QrCodeScanningService))]
namespace HBSSCAN.iOS.Service
{
    public class QrCodeScanningService : IQrCodeScanningService
    {
        public async Task<string> ScanAsync()
        {

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Aproxime a câmera do código de barra",
                BottomText = "Toque na tela para focar"
            };
            var scanResults = await scanner.Scan();
            //Fix by Ale
            return (scanResults != null) ? scanResults.Text : string.Empty;

        }
    }
}