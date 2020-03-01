namespace Caprice.Services
{
    internal class TextToHtmlService : ITextToHtmlService
    {
        public string Transform(string text)
        {
            return text
                .Replace("\r\n", "<br />")
                .Replace("\r", "<br />")
                .Replace("\n", "<br />");
        }
    }
}
