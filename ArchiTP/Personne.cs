using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiTP
{
    public class Personne
    {
        public string uuidPerson;
        public string prenom;
        public string nom;
        public string uuidBatiment;

        public string idBadge;
        public Role role;
    }

    public enum Role
    {
        ENSEIGNANT,
        PERSONNEL_ADMINISTRATIF,
        ETUDIANT
    }

}