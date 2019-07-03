using System.Threading.Tasks;

namespace HBSSCAN.Service
{
    public interface IQrCodeScanningService
    {
        Task<string> ScanAsync();
    }
}
