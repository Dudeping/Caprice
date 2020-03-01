using Caprice.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Caprice.Services
{
    public interface INoteService
    {
        Task<Note> GetAsync(int id);
        Task<bool> DeleteAsync(int id);
        Task<bool> CreateAsync(Note note);
        Task<bool> UpdateAsync(Note note);
        IEnumerable<Note> GetNotes();
    }
}
