using The.Bet.Api.Models;

namespace The.Bet.Api.Services.Interfaces
{
    public interface IBetService
    {
        int PlaceBet(int bet);
        int Spin();
        IEnumerable<BetModel> GetBets();
    }
}
