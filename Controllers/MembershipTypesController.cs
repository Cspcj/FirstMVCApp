using FirstMVCApp.Repositories;
using Microsoft.AspNetCore.Mvc;

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
