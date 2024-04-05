using Serenity.Services;

namespace SportShop.Administration
{
    public class TranslationListRequest : ListRequest
    {
        public string SourceLanguageID { get; set; }
        public string TargetLanguageID { get; set; }
    }
}