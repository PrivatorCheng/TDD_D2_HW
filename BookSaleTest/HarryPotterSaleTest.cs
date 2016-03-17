using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookSale;

namespace BookSaleTest
{
    /// <summary>
    /// HarryPotterSaleTest 的摘要描述
    /// 前置說明 : 專案BookSale內已有處理一般書籍訂單的類別BookOrderHandler
    ///            為了哈利波特優惠新增繼承BookOrderHandler的類別HarryPotterSaleHandler, 計算優惠特價
    /// </summary>
    [TestClass]
    public class HarryPotterSaleTest
    {
        public HarryPotterSaleTest()
        {
            //
            // TODO: 在此加入建構函式的程式碼
            //
        }

        //private TestContext testContextInstance;

        ///// <summary>
        /////取得或設定提供目前測試回合
        /////相關資訊與功能的測試內容。
        /////</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        #region 其他測試屬性
        //
        // 您可以使用下列其他屬性撰寫測試: 
        //
        // 執行該類別中第一項測試前，使用 ClassInitialize 執行程式碼
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在類別中的所有測試執行後，使用 ClassCleanup 執行程式碼
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在執行每一項測試之前，先使用 TestInitialize 執行程式碼 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在執行每一項測試之後，使用 TestCleanup 執行程式碼
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        //Scenario 1: 單獨購買一本哈利波特, 沒有折扣
        [TestMethod]
        public void GetPriceTest_S1_Buy1Book_ShouldBeNoDiscount_Return_100()
        {
            //arrange
            BookOrderHandler bo = new HarryPotterSaleHandler();
            double expectedPrice = 100;
            List<BookOrderModel> boList = new List<BookOrderModel>()
            {
                new BookOrderModel { BookID = "0001", OrderAmt = 1  }
            };

            //act
            double actualPrice = bo.GetBookOrderPrice(boList);

            //return
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
