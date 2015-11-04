using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astronauts_Activities
{
    class Category
    {
        private string CategoryName;
        List<Activity> Activities;

        public Category(string CategoryName)
        {
            this.CategoryName = CategoryName;
            Activities = new List<Activity>();
        }

        public void addActivity(Activity activity)
        {
            Activities.Add(activity);
        }
    }
}
