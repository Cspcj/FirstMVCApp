using FirstMVCApp.Repositories;

namespace FirstMVCApp.Controllers
{
    public class MembersController
    {
        private readonly MembersRepository _membersRepository;

        public MembersController(MembersRepository repository)
        {
            _membersRepository = repository;
        }
    }
}
