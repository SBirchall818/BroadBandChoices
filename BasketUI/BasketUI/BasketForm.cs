using BasketLogic.Basket;
using BasketLogic.BasketItems;
using System;
using System.Globalization;
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

        #region Public

        public void ButterButton_Click(object sender, EventArgs e)
        {
            _basket.AddItem(new ButterItem());
            UpdateTotal();
        }

        #endregion

        #region Private

        private void UpdateTotal()
        {
            TotalTextBox.Text = _basket.Total.ToString("c2", new CultureInfo("en-GB"));
        }

        #endregion
    }
}
