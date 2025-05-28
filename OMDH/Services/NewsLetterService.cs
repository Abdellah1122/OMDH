using Microsoft.EntityFrameworkCore;
using OMDH.Data;
using OMDH.Models;

namespace OMDH.Services
{
    public class NewsLetterService
    {
        private readonly DataContext _context;
        public NewsLetterService( DataContext context)
        {
            _context = context;
        }
        public async Task<List<EmailUserName>> GetAll()
        {
            return await _context.NewsLetterSubscriptions.ToListAsync();
        }
        public async Task CreateAsync(EmailUserName EU)
        {
            _context.NewsLetterSubscriptions.Add(EU);
            await _context.SaveChangesAsync();
        }
    }
}
