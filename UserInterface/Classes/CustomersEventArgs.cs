using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Classes
{
    class CustomersEventArgs:EventArgs
    {
        public Api.Klienci Klienci { private set; get; }

        public CustomersEventArgs(Api.Klienci klient)
        {
            Klienci = klient;
        }
    }
}
