using FirstMVCApp.Models;

namespace FirstMVCApp.VuewModels
{
    public class MemberCodeSnippetsViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Position{ get; set; }
        public List<CodeSnippetModel> CodeSnippets = new List<CodeSnippetModel>();
    }
}
