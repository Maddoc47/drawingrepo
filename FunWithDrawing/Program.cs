using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the startup class from our Program.
            Application.EnableVisualStyles();
            Application.Run(new DrawForm("The Drawing Pad"));
        }
    }
}
