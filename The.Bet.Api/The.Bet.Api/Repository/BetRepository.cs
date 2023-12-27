using System.Data.SqlClient;
using The.Bet.Api.Models;
using The.Bet.Api.Repository.Interfaces;

namespace The.Bet.Api.Repository
{
    public class BetRepository : IBetRepository
    {
        private readonly IConfiguration configuration;
        public BetRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public IEnumerable<BetModel> GetBets()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("Conn")))
            {
                connection.Open();
                throw new NotImplementedException();
            }
        }

        public int PlaceBet(int bet)
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("Conn")))
            {
                connection.Open();
                throw new NotImplementedException();
            }
        }

        public int Spin()
        {
            using (var connection = new SqlConnection(configuration.GetConnectionString("Conn")))
            {
                connection.Open();
                throw new NotImplementedException();
            }
        }
    }
}
