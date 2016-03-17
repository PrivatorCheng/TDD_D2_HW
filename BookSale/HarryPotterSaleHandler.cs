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
            double dDiscount;
            switch (orderCnt)
            {
                case 2:
                    dDiscount = 0.95;
                    break;
                case 3:
                    dDiscount = 0.9;
                    break;
                default:
                    dDiscount = 1;
                    break;
            }
            orderPrice = orderPrice * dDiscount;
            return orderPrice;
        }
    }
}