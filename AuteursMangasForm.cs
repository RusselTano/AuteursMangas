using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AuteursMangas
{
    public partial class AuteursMangasForm : Form
    {
        #region Champs privés 


        #endregion


        #region Initialisation
        public AuteursMangasForm()
        {
            InitializeComponent();

        }
        private void AuteursMangasForm_Load(object sender, EventArgs e)
        {
            //Appel de la méthode située dans la classe générale pour initialiser les listes

            //Appel de la methode Méthode InitDialogue() pour Initialiser les propriete des deux Boites de dialog
        }

        #endregion

        #region Usager choisit une nouvelle photo à partir d'un fichier .gif, .jpg etc. et l'affiche
        private void ouvrirUnePhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Méthode OuvrirPhoto()
            // Try /catch
            // Vérifier si l’utilisateur a cliqué sur OK
            // Insérer le nom de l’image dans la liste
            // Sélectionner l’image une fois insérée dans la liste
            // LoadAsync dépendant de la position dans le code.
        }

        #endregion



        #region Polices
        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Méthode FormatPolice()
            // Try /catch
            // Vérifier si l’utilisateur a cliqué sur OK
            // Modifier la police de la liste
            // Modifier la couleur de la liste
        }
        #endregion


        private void selectButton_Click(object sender, EventArgs e)
        {
            //Méthode TransfererAlgorithme()
        }

        private void pairButton_Click(object sender, EventArgs e)
        {
            //Méthode Pair()
        }

        private void impairButton_Click(object sender, EventArgs e)
        {
            //Méthode Impair()
        }

        #region Méthodes privées

        //Méthode InitDialogue()
        // OpenFileDialog
        //Dossier par défaut(dossier Image en passant par le dossier par défaut)
        //Titre
        //Nom du fichier
        //Filtre
        //=======================
        // FontDialog
        //Couleur visible
        //Police doit exister
        //Valeur minimale
        //Valeur maximale

        //Méthode TransfererAlgorithme()
        // Effacer la liste
        // Boucle
        // Les deux conditions selon le choix sont vérifiées
        // Ajouter les éléments dans la liste

        //Méthode Pair()
        // Effacer les sélections
        // Sélectionner les éléments pair dans la liste

        //Méthode Impair()
        // Effacer les sélections
        // Sélectionner les éléments impair dans la liste

        #endregion

    }
}
