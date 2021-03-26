using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{
    public class Batiment
    {
        public string id;

        public List<Badge> badges;

        public Lecteur lecteur;
        public List<Personne> personnesDansBatiment;

        public Porte porte;


        public Batiment(){
            lecteur = new Lecteur(this);
        }


        public bool BadgeEstAutorise(string _idBadge){
          foreach (var badge in badges)
          {
              if (badge.id == _idBadge)
              {
                  return true;
              }
              
          }   
          return false;       
        }


        
        public void InOutPersonne(Badge _badge){
          
          bool personneDansListe = false;

          foreach (var personne in personnesDansBatiment)
          {
              if (_badge.idPersonne == personne.uuidPerson)
              {
                  personneDansListe = true;
              }
          }

          if(personneDansListe){
            //Enlever personne de personnesDansBatiment
          }
          else{
            //Ajouter la personne
          }

          //Retrouver la personne dans personnesdansbatiments avec le badge
            //si elle y est, on l'enlève
            //si elle n'y est pas on l'ajoute
        }

    }




}