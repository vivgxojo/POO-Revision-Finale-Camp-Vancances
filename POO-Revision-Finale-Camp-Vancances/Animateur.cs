﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Revision_Finale_Camp_Vancances
{
    public class Animateur : Employe, IEncadrant
    {
        public string AnimerActivite(Activite activite)
        {
            return ($"L'animateur {Nom} anime l'activité {activite.Nom}.");
        }
        public string SurveillerCampeurs()
        {
            return($"L'animateur {Nom} surveille les campeurs.");
        }
    }
}
