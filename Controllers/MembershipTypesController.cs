using FirstMVCApp.Repositories;

namespace FirstMVCApp.Controllers
{
    public class MembershipTypesController
    {
        private readonly MembershipTypeRepository _membershipTypeRepository;

        public MembershipTypesController(MembershipTypeRepository repository)
        {
            _membershipTypeRepository = repository;
        }
    }
}
