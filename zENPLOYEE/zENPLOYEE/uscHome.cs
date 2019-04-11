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
    public partial class uscHome : UserControl
    {
        private static uscHome instance;

        public static uscHome Instance
        {
            get
            {
                if (instance == null)
                    return instance = new uscHome();
                return instance;
            }
        }

        public uscHome()
        {
            InitializeComponent();
        }
    }
}
