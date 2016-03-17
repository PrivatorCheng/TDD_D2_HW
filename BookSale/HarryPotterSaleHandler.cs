using BookSale;
using System.Collections.Generic;
using System.Linq;

namespace BookSale
{
    public class HarryPotterSaleHandler : BookOrderHandler
    {
        public override double GetBookOrderPrice(List<BookOrderModel> boList)
        {
            double orderPrice = 0;
            int orderCnt = 0;
            foreach (BookOrderModel bo in boList)
            {
                BookDataModel b = _BookList.Where(x => x.BookID == bo.BookID).FirstOrDefault();
                if (b != null) orderPrice += bo.OrderAmt * b.BookPrice;
                orderCnt += 1;
            }
            if (orderCnt == 2)
            {
                orderPrice = orderPrice * 0.95;
            }
            return orderPrice;
        }
    }
}