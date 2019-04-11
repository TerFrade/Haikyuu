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
    public partial class uscLeave : UserControl
    {
        private static uscLeave instance;

        public static uscLeave Instance{
            get
            {
                if (instance == null)
                    return instance = new uscLeave();
                return instance;
            }
        }
        public uscLeave()
        {
            InitializeComponent();
        }
    }
}
