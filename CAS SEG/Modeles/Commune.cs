using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    class Commune
    {
        #region Attributs
        public static ArrayList collClassCommune = new ArrayList();

        private int _numCom;
        private string _nomCom;


        #endregion

        #region constructeur
        public Commune(int numCom, string nomCom)
        {
            NumCom = numCom;
            NomCom = nomCom;
        }
        #endregion

        #region getSet
        public int NumCom { get => _numCom; set => _numCom = value; }
        public string NomCom { get => _nomCom; set => _nomCom = value; }
        #endregion

        #region methodes
        public void ajouterUnSecteur()
        {

        }

        public ArrayList secteurEV()
        {
            return collClassCommune;
        }

        public int volumeVannes()
        {
            return 0;
        }

        public string pertes()
        {
            return "a";
        }

        public string anomalies()
        {
            return "a";
        }
        #endregion
    }
}
