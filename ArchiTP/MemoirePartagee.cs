using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{
    public class MemoirePartagee
    {
        public MemoirePartagee(){
            if(Singleton == null){
                Singleton = this;
            }
        }

        public static MemoirePartagee Singleton;
        public List<LogScan> logScans = new List<LogScan>();
        public List<Batiment> batiments= new List<Batiment>();
        public List<Badge> badges = new List<Badge>();
        public List<Personne> personnes = new List<Personne>();

    }
}
