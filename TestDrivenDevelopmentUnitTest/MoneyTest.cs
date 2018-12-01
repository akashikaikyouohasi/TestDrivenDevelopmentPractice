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

            //Equalメソッドを実装したので、参照の比較ではなく実装したメソッドにて比較が行われる。
            Assert.AreEqual(new Dollar(10), five.Times(2));

            Assert.AreEqual(new Dollar(15), five.Times(3));
        
        }

        [TestMethod]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}
