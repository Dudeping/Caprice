using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caprice.Services
{
    public interface ITextToHtmlService
    {
        string Transform(string text);
    }
}
