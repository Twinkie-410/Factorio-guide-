using System.Windows;

namespace Factorio_guide__WPF
{
    public class Storage : Logistics
    {
        public int StorageSize { get; set; }
        public int Health { get; set; }
        public const int StackSize = 50;
        public Size Dimensions { get; set; }

        public Storage(string name, string[] description, Recipe recipe, TotalRaw totalRaw, int storageSize, int health,
            Size dimensions, RequiredTechnologies technologies = default, ProducedBy producedBy = default)
        {
            Name = name;
            Description = description;
            Recipe = recipe;
            StorageSize = storageSize;
            Health = health;
            Dimensions = dimensions;
            RequiredTechnologies = technologies;
            ProducedBy = producedBy;
        }
    }
}