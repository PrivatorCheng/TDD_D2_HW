using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSale
{
    internal class BookDataDao
    {
        internal List<BookDataModel> GetAllBook()
        {
            return new List<BookDataModel>()
            {
                new BookDataModel { BookID = "0001", BookName = "Harry Potter Vol. 1", BookPrice = 100 },
                new BookDataModel { BookID = "0002", BookName = "Harry Potter Vol. 2", BookPrice = 100 },
                new BookDataModel { BookID = "0003", BookName = "Harry Potter Vol. 3", BookPrice = 100 },
                new BookDataModel { BookID = "0004", BookName = "Harry Potter Vol. 4", BookPrice = 100 },
                new BookDataModel { BookID = "0005", BookName = "Harry Potter Vol. 5", BookPrice = 100 },
                new BookDataModel { BookID = "0006", BookName = "Harry Potter Vol. 6", BookPrice = 100 },
                new BookDataModel { BookID = "0007", BookName = "Harry Potter Vol. 7", BookPrice = 100 }
            };
        }
    }
}
