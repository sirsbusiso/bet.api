using The.Bet.Api.Models;

namespace The.Bet.Api.Repository.Interfaces
{
    public interface IBetRepository
    {
        int PlaceBet(int bet);
        int Spin();
        IEnumerable<BetModel> GetBets();
    }
}
