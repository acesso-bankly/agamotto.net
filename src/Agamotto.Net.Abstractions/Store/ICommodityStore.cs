using System.Threading.Tasks;

namespace Agamotto.Net.Abstractions.Store
{
    public interface ICommodityStore<TCommodity> where TCommodity : class, ICommodity
    {
        Task<ICommodity> GetAsync(string aggregateKey);
        
        Task SaveAsync(ICommodity data);
    }
}