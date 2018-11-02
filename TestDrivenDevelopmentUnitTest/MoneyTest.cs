using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentPractice;

/*
 * テストプロジェクトの参照に、テストするプロジェクトの参照を追加すること
 * 以下、参考情報
 * https://qiita.com/mima_ita/items/55394bcc851eb8b6dc24
 * https://qiita.com/mima_ita/items/05ce44c3eb1fd6e9dd46
 */

//動作させる⇒きれいにするの順序で行う


namespace TestDrivenDevelopmentUnitTest
{
    [TestClass]
    public class MoneyTest
    {
        [TestMethod]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.AreEqual(10, five.amount);

            five.Times(3);
            Assert.AreEqual(15, five.amount);
        
        }
    }
}
