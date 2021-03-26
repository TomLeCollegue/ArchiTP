using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{

    public class Porte
    {
        public bool Closed = true;

        public void OuvrirPorte(){
            Closed = false;
        }
    }
}