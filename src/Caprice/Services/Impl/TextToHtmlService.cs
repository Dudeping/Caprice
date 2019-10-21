using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caprice.Services
{
    internal class TextToHtmlService : ITextToHtmlService
    {
        public string Transform(string text)
        {
            return text.Replace("\r\n", "<br />");
        }
    }
}
