using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketUI;

namespace BasketUITests
{
    [TestClass]
    public class SetupTests
    {
        [TestMethod]
        public void BasketUICanBeInitializedWithABasket()
        {
            BasketForm basketForm = new BasketForm(new Basket());
        }
    }
}
