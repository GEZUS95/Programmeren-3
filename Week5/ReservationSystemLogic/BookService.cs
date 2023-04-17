using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationSystemLogic
{
    public class BookService
    {
        BookDAO dao = new BookDAO();

        public List<Book> GetAll()
        {
            return dao.GetAll();
        }

        public Book GetById(int id)
        {
            return dao.GetById(id);
        }

        public List<Book> GetByAuthor(string authorName)
        {
            return dao.GetByAuthor(authorName);
        }
    }
}
