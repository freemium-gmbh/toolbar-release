﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using RegistryCompactor.Properties;
using FreemiumUtil;

namespace RegistryCompactor
{
    public partial class TopControl : UserControl
    {
        /// <summary>
        /// constructor for TopControl
        /// </summary>
        public TopControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Top control text
        /// </summary>
        public override string Text
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        /// <summary>
        /// handle MouseEnter event to change help icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void lblHelp_MouseEnter(object sender, EventArgs e)
        {
            lblHelp.Image = Resources.help_on;
        }

        /// <summary>
        /// handle MouseLeave event to change help icon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void lblHelp_MouseLeave(object sender, EventArgs e)
        {
            lblHelp.Image = Resources.help_off;
        }

        /// <summary>
        /// handle Click event to open help url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void lblHelp_Click(object sender, EventArgs e)
        {
            try
            {
                CommonOperations.OpenUrl(Resources.HelpUrl);
            }
            catch (Exception)
            { }
        }
    }
}