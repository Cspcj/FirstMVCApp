using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class MembersRepository
    {
        private readonly ProgrammingClubDataContext _context;

        public MembersRepository(ProgrammingClubDataContext context)
        {
            _context = context;
        }

        //public DbSet<MembershipModel> GetAllMembers()
        //{
        //    return _context.Members;
        //}
        
    }
}
