using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{

    /// <summary>
    /// Classe représentant un astronaute, définie à partir du fichier XML de mission.
    /// </summary>
    public class Astronaut
    {
        public string Name { get; private set; }
        public bool Available { get; set; } //Can be used to stop an astronaut from doing 2 tasks at once

        /// <summary>
        /// Constructeur de la classe Astronaut
        /// </summary>
        /// <param name="n">String : Le nom de l'astronaut</param>
        public Astronaut(string n)
        {
            Name = n;
            Available = true;
        }

        /// <summary>
        /// Implémentation de la classe ToString() pour la classe Astronaut
        /// </summary>
        /// <returns>Un string</returns>
        public override string ToString()
        {
            if (Available == true)
            { return Name + " is available"; }
            else
            { return Name + " is not available"; }
        }
    }
}
