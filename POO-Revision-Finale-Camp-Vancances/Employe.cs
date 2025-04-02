using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Revision_Finale_Camp_Vancances
{
    public class Employe : Personne
    {
        public string Poste { get; set; } 
        public int Experience { get; set; }
        public ObservableCollection<Activite> ActivitesEncadrees { get; set; } = new ObservableCollection<Activite>();
    }
}
