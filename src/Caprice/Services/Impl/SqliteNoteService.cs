using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caprice.Data;
using Caprice.Models;

namespace Caprice.Services
{
    public class SqliteNoteService : INoteService
    {
        private readonly SqliteDbContext _context;

        public SqliteNoteService(SqliteDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(Note note)
        {
            try
            {
                await _context.AddAsync(note);

                return await _context.SaveChangesAsync() == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var note = await this.GetAsync(id);

                if (note != null)
                {
                    _context.Remove(note);

                    return await _context.SaveChangesAsync() == 1;
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Note> GetAsync(int id)
        {
            return await _context.Notes.FindAsync(id);
        }

        public IEnumerable<Note> GetNotes()
        {
            return _context.Notes;
        }

        public async Task<bool> UpdateAsync(Note note)
        {
            try
            {
                _context.Update(note);

                return await _context.SaveChangesAsync() == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
