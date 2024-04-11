﻿using System;
using System.Windows.Forms;

namespace VisioAddin
{
    public partial class ThisAddIn
    {
        public void TogglePanel()
        {
            _panelManager.TogglePanel(Application.ActiveWindow);
        }

        private PanelManager _panelManager;

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            _panelManager = new PanelManager(this);
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            _panelManager.Dispose();
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += ThisAddIn_Startup;
            Shutdown += ThisAddIn_Shutdown;
        }
    }
}