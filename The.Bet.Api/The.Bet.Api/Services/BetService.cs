using The.Bet.Api.Models;
using The.Bet.Api.Repository.Interfaces;
using The.Bet.Api.Services.Interfaces;

namespace The.Bet.Api.Services
{
    public class BetService : IBetService
    {
        private readonly IBetRepository _iBetRepository;

        public BetService(IBetRepository betRepository)
        {
            _iBetRepository = betRepository;
        }
        public IEnumerable<BetModel> GetBets()
        {
            return _iBetRepository.GetBets();
        }

        public int PlaceBet(int bet)
        {
           return _iBetRepository.PlaceBet(bet);
        }

        public int Spin()
        {
            return _iBetRepository.Spin();
        }
    }
}
