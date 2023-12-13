using WineShopAritz.Models;

namespace WineShopAritz.Services
{
    public interface IArdoaService
    {
        Task<IList<ArdoaUpeltegi>> GetMota(int id);

        Task<List<Ardoa>> GetArdoak();
    }
}
