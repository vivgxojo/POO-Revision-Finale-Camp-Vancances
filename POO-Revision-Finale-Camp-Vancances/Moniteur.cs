﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Revision_Finale_Camp_Vancances
{
    public class Moniteur : Employe, IEncadrant
    {
        public string AnimerActivite(Activite activite)
        {
            return($"Le moniteur {Nom} anime l'activité {activite.Nom}.");
        }
        public string SurveillerCampeurs()
        {
            return($"Le moniteur {Nom} surveille les campeurs.");
        }
    }
}
