using FirstMVCApp.DataContext;

namespace FirstMVCApp.Repositories
{
    public class MembershipTypeRepository
    {

        private readonly ProgrammingClubDataContext _context;
        public MembershipTypeRepository(ProgrammingClubDataContext context) => _context = context;
    }
}
