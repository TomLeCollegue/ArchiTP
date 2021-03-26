using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{
    public class Lecteur
    {
        public Batiment batiment;
        public Lecteur(Batiment batiment){
            this.batiment = batiment;
        }

        public bool LectureCarte(string id_badge){
          if (batiment.BadgeEstAutorise(id_badge))
          {
              return true;
          }
          else
          {
              return false;
          }
        }

        public void DemanderOuverturePorte(Badge badge){
            if(LectureCarte(badge.id)){
                batiment.porte.OuvrirPorte();
              //Enregistrer dans la liste des personnes du batiment au moment T ou l'enlever
                batiment.InOutPersonne(badge);
            //engistrer dans les logs
                
            }

            
            

        }

        


    }
}
