using habilitations2024.dal;
using habilitations2024.model;
using System;

namespace habilitations2024.controller
{
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly DeveloppeurAccess developpeurAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            developpeurAccess = new DeveloppeurAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="admin">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Admin admin)
        {
            return developpeurAccess.ControleAuthentification(admin);
        }

    }
}
