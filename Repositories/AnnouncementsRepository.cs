using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class AnnouncementsRepository
    {
        // clasele de tip repository sunt clase care implementeaza operatiile CRUD pe Baza de date

        private readonly ProgrammingClubDataContext _context;

        public AnnouncementsRepository(ProgrammingClubDataContext context)
        {
            _context= context;
        }

        // metoda echivalenta Get
        public DbSet<AnnouncementModel> GetAnnouncements ()
        {
            return _context.Announcements;
        }
    }
}
