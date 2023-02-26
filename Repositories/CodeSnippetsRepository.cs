using FirstMVCApp.DataContext;

namespace FirstMVCApp.Repositories
{
    public class CodeSnippetsRepository
    {
        private readonly ProgrammingClubDataContext _context;

        public CodeSnippetsRepository(ProgrammingClubDataContext context)
        {
            _context = context;
        }


    }
}
