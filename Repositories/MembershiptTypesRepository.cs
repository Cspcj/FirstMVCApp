using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class MembershiptTypesRepository
    {
        private readonly ProgrammingClubDataContext _context;

        public MembershiptTypesRepository(ProgrammingClubDataContext context) => _context = context;

        public DbSet<MembershipTypeModel> GetAllMembershipTypes()
        {
            return _context.MembershipTypes;
        }
    }
}
