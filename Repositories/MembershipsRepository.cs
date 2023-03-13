using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Repositories
{
    public class MembershipsRepository
    {
        private readonly ProgrammingClubDataContext _context;
        public MembershipsRepository(ProgrammingClubDataContext context) => _context = context;

      

        public MembershipModel getMembershipById(Guid Id)
        {
            return _context.Memberships.FirstOrDefault(x => x.IDMembership == Id);
        }

    }
}
