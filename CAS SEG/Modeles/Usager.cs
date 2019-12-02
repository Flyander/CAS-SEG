using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    class Usager : Branchement
    {
        #region Attributs
        //public static ArrayList CollClasseUsager = new ArrayList();
        public Usager()
        {
            Branchement.CollClasseBranchement.Add(this);
        }
        #endregion

        #region Constructeur
        public Usager()
        {
            Branchement.CollClasseBranchement.Add(this);
        }
        #endregion

        #region Getter Setter

        #endregion

        #region Methodes

        public override int conso()
        {
            return 1 ; //Valeur d'essai
        }

        #endregion

    }
    }
