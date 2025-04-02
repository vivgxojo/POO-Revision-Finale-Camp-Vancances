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
        
        public event PropertyChangedEventHandler? PropertyChanged;

        // TODO : Ajouter OnPropretyChanged au besoin
    }
}
