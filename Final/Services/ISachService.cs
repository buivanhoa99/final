using Final.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Services
{
    public interface ISachService
    {
        List<Sach> GetAllBooks();
        List<Sach> GetBooksById(int id);
    }
}
