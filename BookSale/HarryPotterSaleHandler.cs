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

            while (! NoBookInOrderList(boList))
            {
                double tmpOrderPrice = 0;
                foreach (BookOrderModel bo in boList)
                {
                    BookDataModel b = _BookList.Where(x => x.BookID == bo.BookID).FirstOrDefault();
                    if (b != null && bo.OrderAmt != 0)
                    {
                        tmpOrderPrice += b.BookPrice;
                        bo.OrderAmt -= 1;
                    }
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
                    case 4:
                        dDiscount = 0.8;
                        break;
                    case 5:
                        dDiscount = 0.75;
                        break;
                    default:
                        dDiscount = 1;
                        break;
                }
                tmpOrderPrice = tmpOrderPrice * dDiscount;
                orderPrice += tmpOrderPrice;
            }

            return orderPrice;
        }
        private bool NoBookInOrderList(List<BookOrderModel> boList)
        {
            bool f = true;
            foreach(BookOrderModel bo in boList)
            {
                if (bo.OrderAmt != 0) f = false;
            }
            return f;
        }
    }
}