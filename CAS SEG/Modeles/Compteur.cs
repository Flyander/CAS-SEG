using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    class Compteur
    {
        #region Attributs
        public static ArrayList collClassCompteur = new ArrayList();

        private int _indexAncien;
        private int _indexNouveau;
        #endregion

        #region Constructeurs
        public Compteur(int indexAncien, int indexNouveau)
        {
            IndexAncien = indexAncien;
            IndexNouveau = indexNouveau;
        }
        #endregion

        #region Getters/Setters
        public int IndexAncien { get => _indexAncien; set => _indexAncien = value; }
        public int IndexNouveau { get => _indexNouveau; set => _indexNouveau = value; }
        #endregion

        #region Methodes
        public int releve()
        {
            return (IndexNouveau - IndexAncien);
        }
        #endregion
    }
}
