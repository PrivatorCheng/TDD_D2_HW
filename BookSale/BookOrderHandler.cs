using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookSale
{
    public abstract class BookOrderHandler
    {
        private List<BookDataModel> _BookList;
        public BookOrderHandler()
        {
            BookDataDao bDao = new BookDataDao();
            _BookList = bDao.GetAllBook();
        }

        public double GetBookOrderPrice(List<BookOrderModel> boList)
        {
            double orderPrice = 0;
            foreach (BookOrderModel bo in boList)
            {
                BookDataModel b = _BookList.Where(x => x.BookID == bo.BookID).FirstOrDefault();
                if (b != null) orderPrice += bo.OrderAmt * b.BookPrice;
            }
            return orderPrice;
        }
    }
}
