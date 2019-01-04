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
            Money five = Money.dollar(5);

            //Equalメソッドを実装したので、参照の比較ではなく実装したメソッドにて比較が行われる。
            Assert.AreEqual(Money.dollar(10), five.Times(2));

            Assert.AreEqual(Money.dollar(15), five.Times(3));
        
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.IsFalse(Money.dollar(5).Equals(Money.dollar(6)));

            Assert.IsTrue(Money.franc(5).Equals(Money.franc(5)));
            Assert.IsFalse(Money.franc(5).Equals(Money.franc(6)));

            Assert.IsFalse(Money.franc(5).Equals(Money.dollar(5)));
        }

        [TestMethod]
        public void TestFrancMultiplication()
        {
            Franc five = Money.franc(5);

            Assert.AreEqual(Money.franc(10), five.Times(2));
            Assert.AreEqual(Money.franc(15), five.Times(3));

        }
    }
}
