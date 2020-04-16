using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Labs
{
    [Serializable]
    public class FormWindow
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public FormWindowState FormWindowState { get; set; }
    }
}
