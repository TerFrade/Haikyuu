using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zENPLOYEE
{
    public partial class uscSettings : UserControl
    {
        private static uscSettings instance;

        public static uscSettings Instance{
            get
            {
                if (instance == null)
                    return instance = new uscSettings();
                return instance;
            }
        }
        public uscSettings()
        {
            InitializeComponent();
        }
    }
}
