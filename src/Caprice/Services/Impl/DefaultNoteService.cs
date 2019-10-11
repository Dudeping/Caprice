using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caprice.Models;

namespace Caprice.Services
{
    internal class NoteService : INoteService
    {
        private static int _id = 0;
        private static readonly IDictionary<int, Note> _notes = new Dictionary<int, Note>();

        public async Task<Note> GetAsync(int id)
        {
            await Task.Yield();

            return _notes[id];
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await Task.Yield();

            if (_notes.ContainsKey(id))
            {
                return _notes.Remove(id);
            }

            return false;
        }

        async Task<bool> INoteService.CreateAsync(Note note)
        {
            await Task.Yield();

            note.Id = ++_id;

            _notes.Add(_id, note);

            return true;
        }

        public async Task<bool> UpdateAsync(Note note)
        {
            await Task.Yield();

            _notes[note.Id] = note;

            return false;
        }

        public IEnumerable<Note> GetNotes()
        {
            return _notes.Values;
        }
    }
}
