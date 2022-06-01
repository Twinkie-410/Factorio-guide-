using System.Collections.Generic;

namespace Factorio_guide__WPF
{
    public class Recipe
    {

        public double Time { get; set; }
    
        public List<Entity> Resources{get; set; }
        public Recipe(double time, List<Entity> resources = null)
        {
            Time = time;
            Resources = resources;
        }
    }
}