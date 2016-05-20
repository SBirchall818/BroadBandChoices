using BasketLogic.Basket;
using BasketLogic.BasketItems;
using System;
using System.Windows.Forms;

namespace BasketUI
{
    public partial class BasketForm : Form
    {
        #region Fields

        private IBasket _basket;

        #endregion

        #region Constructors

        public BasketForm()
        {
            InitializeComponent();
        }

        public BasketForm(IBasket basket)
        {
            _basket = basket;
            InitializeComponent();
        }

        #endregion

        public void ButterButton_Click(object sender, EventArgs e)
        {
            _basket.AddItem(new ButterItem());
        }
    }
}
