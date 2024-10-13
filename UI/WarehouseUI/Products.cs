﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseUI
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnReserNameFilter_Click(object sender, EventArgs e)
        {
            tbSearchString.Text = string.Empty;
        }

        private void btnToggleFromFilter_Click(object sender, EventArgs e)
        {
            dtpAfterFilter.Enabled = !dtpAfterFilter.Enabled;
        }
        private void btnToggleToFilter_Click(object sender, EventArgs e)
        {
            dtpBeforeFilter.Enabled = !dtpBeforeFilter.Enabled;
        }
        private void btnResetDateFilter_Click(object sender, EventArgs e)
        {
            ResetDateFilter();
        }
        private void ResetDateFilter()
        {
            dtpAfterFilter.Enabled = false;
            dtpAfterFilter.Value = DateTime.Now;

            dtpBeforeFilter.Enabled = false;
            dtpBeforeFilter.Value = DateTime.Now;
        }

        private void btnTogglePriceFrom_Click(object sender, EventArgs e)
        {
            numPriceFromFilter.Enabled = !numPriceFromFilter.Enabled;
        }
        private void btnTogglePriceTo_Click(object sender, EventArgs e)
        {
            numPriceToFilter.Enabled = !numPriceToFilter.Enabled;
        }
        private void butResetPriceFilter_Click(object sender, EventArgs e)
        {
            ResetPriceFilter();
        }
        private void ResetPriceFilter()
        {
            numPriceFromFilter.Enabled = false;
            numPriceFromFilter.Value = 0m;

            numPriceToFilter.Enabled = false;
            numPriceToFilter.Value = 0m;
        }

        private void btnToggleQuantityFrom_Click(object sender, EventArgs e)
        {
            numQuantityFromFilter.Enabled = !numQuantityFromFilter.Enabled;
        }
        private void btnToggleQuantityTo_Click(object sender, EventArgs e)
        {
            numQuantityToFilter.Enabled = !numQuantityToFilter.Enabled;
        }

        private void btnResetQuantityFilter_Click(object sender, EventArgs e)
        {
            ResetQuantityFilter();
        }
        private void ResetQuantityFilter()
        {
            numQuantityFromFilter.Enabled = false;
            numQuantityFromFilter.Value = 0;

            numQuantityToFilter.Enabled = false;
            numQuantityFromFilter.Value = 0;
        }

        private void btnResetAllFilters_Click(object sender, EventArgs e)
        {
            tbSearchString.Text = string.Empty;
            ResetDateFilter();
            ResetPriceFilter();
            ResetQuantityFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTargetUrl_TextChanged(object sender, EventArgs e)
        {
            Target.Url = tbTargetUrl.Text;
        }
    }
}