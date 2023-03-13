using FirstMVCApp.Models;

namespace FirstMVCApp.VuewModels
{
    public class MembershipTypesMembersViewModel
    {   
        public string Name { get; set; }
        public string Description { get; set; }
        public List<MemberModel> members = new List<MemberModel>();
        public int Count { get; set;}
    }
}
