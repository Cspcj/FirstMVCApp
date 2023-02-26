using FirstMVCApp.DataContext;

namespace FirstMVCApp.Repositories
{
    public class MembershiptTypesRepository
    {
        private readonly ProgrammingClubDataContext _context;

        public MembershiptTypesRepository(ProgrammingClubDataContext context) => _context = context;
    }
}
