using Microsoft.Data.Entity;
using Voting.Model;

namespace Voting.Api.Model
{
    public class VotingContext : DbContext
    {
        public DbSet<Poll> Polls { get; set; }

        public DbSet<Vote> Votes { get; set; }

        public VotingContext()
        {
        }
    }
}
