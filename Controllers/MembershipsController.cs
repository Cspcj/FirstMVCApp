using FirstMVCApp.Repositories;

namespace FirstMVCApp.Controllers
{
    public class MembershipsController
    {
        private readonly MembershipsRepository _membershipRepository;

        public MembershipsController(MembershipsRepository repository)
        {
            _membershipRepository = repository;
        }
    }
}
