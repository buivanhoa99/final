using Final.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Services
{
    public class SachService : ISachService
    {
        private readonly MyDBContext _context;

        public SachService(MyDBContext context)
        {
            this._context = context;
        }

        public List<Sach> GetAllBooks()
        {
            return _context.Sachs.ToList();
        }

        public List<Sach> GetBooksById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
