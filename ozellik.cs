using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    internal class ozellik
    {
        private double miktar = 0;
        private string isim = "yelda fırat";
        public string mudur //properties
        {
            get
            {
              return isim;
            }
            set
            {
                this.isim = value;
            }
        }
        public string butcemiktari
        {
            get 
            {
                return string.Format("{0:c}", miktar);
            }
            set
            { 
                this.miktar = Convert.ToDouble(value);
            }
        }
    }
}
