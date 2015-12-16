using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    /// <summary>
    ///  Classe catégorie qui contiendra les activités
    /// </summary>
    public class Category : Activity
    {
        /// <summary>
        /// Constructeur de la classe Catégorie
        /// </summary>
        /// <param name="CategoryName">String : Nom de la catégorie</param>
        public Category(string CategoryName)
            : base(CategoryName)
        {
            Activities = new List<Activity>();
        }

        /// <summary>
        /// Ajoute une nouvelle Activity à la Category
        /// </summary>
        /// <param name="activity">Activity : Activité que l'on souhaite ajouter</param>
        public void addActivity(Activity activity)
        {
            Activities.Add(activity);
        }
    }
}
