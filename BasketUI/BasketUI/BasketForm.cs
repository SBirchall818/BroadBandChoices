using BasketLogic.Basket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
