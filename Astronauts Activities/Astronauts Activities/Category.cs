using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Category : Activity
    {
        public List<Activity> Activities {get; private set;}

        public Category(string CategoryName):base(CategoryName)
        {
            Activities = new List<Activity>();
        }

        public void addActivity(Activity activity)
        {
            Activities.Add(activity);
        }
    }
}
