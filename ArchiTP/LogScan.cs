using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{
    public class LogScan
    {
        public string uuidPerson;
        public string hour;
        public string uuidBatiment;

        public string idBadge;

        public TypeLog typeLog;


    }

    public enum TypeLog
    {
        ENTRER,
        SORTIE    
    }
}