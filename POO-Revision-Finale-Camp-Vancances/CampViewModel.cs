using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Revision_Finale_Camp_Vancances
{
    class CampViewModel : INotifyPropertyChanged
    {
        // TODO : Ajouter les propriétés manquantes au besoin

        // TODO : Encapsuler les propriétés au besoin et programmer les setters

        public string Nom = "Camp-Reboul";
        public string Lieu = "Hull";
        public int CapaciteMax = 30;
      
        public ObservableCollection<Campeur> Campeurs { get; set; } = new ObservableCollection<Campeur>() {
            new Campeur()
            {
                Prenom = "Alex",
                Nom = "Leblanc",
                Age = 8,
                Allergies = "Aucune"
            },
            new Campeur()
            {
                Prenom = "Joséphine",
                Nom = "Leduc",
                Age = 7,
                Allergies = "Oeufs"
            },
            new Campeur()
            {
                Prenom = "Bob",
                Nom = "Leclair",
                Age = 9,
                Allergies = "Aucune"
            }
        };

        public ObservableCollection<Activite> Activites { get; set; } = new ObservableCollection<Activite>()
        {
            new Activite() {
                Nom = "Tie-Dye"
            }, new Activite() {
                Nom = "Loup-Garou"
            },
            new Activite()
            {
                Nom = "Nerf"
            },
            new Activite()
            {
                Nom = "Lego"
            },
            new Activite()
            {
                Nom = "Dessin"
            },
            new Activite()
            {
                Nom = "Multisport"
            } 
        };

        // TODO : Créer le constructeur du viewModel avec tout ce qui est nécessaire

        // TODO : Gérer le bouton Inscription qui doit permettre d'inscrire les campeurs aux activités.
        // Lors de l'inscription, il doit y avoir des objets sélectionnés dans les 2 grilles 
        // On ajoute le campeur à la liste dans l'objet activité et on ajoute l'activité à la liste dans l'objet campeur
        // Utiliser une fonction anonyme pour désactiver le bouton si les 2 objets ne sont pas sélectionnés.
        
        public event PropertyChangedEventHandler? PropertyChanged;

        // TODO : Ajouter OnPropretyChanged au besoin


        // TODO : Version longue : Ajouter la logique nécessaire pour vos ajouts à l'interface utilisateur.
    }
}
