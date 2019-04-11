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
    public partial class uscTime : UserControl
    {
        private static uscTime instance;

        public static uscTime Instance
        {
            get
            {
                if (instance == null)
                    return instance = new uscTime();
                return instance;
            }
        }

        public uscTime()
        {
            InitializeComponent();
        }
    }
}
