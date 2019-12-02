using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAS_SEG.Modeles
{
    class Secteur
    {
        #region Attributs
        public static ArrayList CollClassSecteurs = new ArrayList();

        private int _numSecteur;
        private string _nomSecteur;
        private bool _espaceVert;
        private Commune _laCommune;
        private ArrayList _lesBranchements;
        #endregion

        #region Constructeurs
        public Secteur(int numSecteur, string nomSecteur, bool espaceVert, Commune laCommune)
        {
            NumSecteur = numSecteur;
            NomSecteur = nomSecteur;
            EspaceVert = espaceVert;
            LaCommune = laCommune;
            LesBranchements = new ArrayList();
        }
        #endregion

        #region Getters/Setters
        public int NumSecteur { get => _numSecteur; set => _numSecteur = value; }
        public string NomSecteur { get => _nomSecteur; set => _nomSecteur = value; }
        public bool EspaceVert { get => _espaceVert; set => _espaceVert = value; }
        public ArrayList LesBranchements { get => _lesBranchements; set => _lesBranchements = value; }
        internal Commune LaCommune { get => _laCommune; set => _laCommune = value; }
        #endregion

        #region Methodes
        #endregion
    }
}
