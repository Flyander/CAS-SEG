using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    class Vanne : Branchement
    {
        #region Constructeurs
        public Vanne(Compteur leCompteur):base(leCompteur)
        {
        }
        #endregion

        #region Methodes
        public override int conso()
        {
            return 1; //Valeur d'essai :3
        }
        #endregion
    }
}
