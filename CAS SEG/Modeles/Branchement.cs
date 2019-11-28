using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    abstract class Branchement
    {
        #region Attributs
        public static ArrayList CollClasseBranchement = new ArrayList();
        private Compteur _leCompteur;
        #endregion

        #region Constructeur

        #endregion

        #region Getter Setter
        internal Compteur LeCompteur { get => _leCompteur; set => _leCompteur = value; }
        #endregion

        #region Methodes
        public abstract int conso();

        #endregion

        }
    }
