namespace Factorio_guide__WPF
{
    public abstract class Entity
    {
        public string Name { get; set; }
        public string[] Description { get; set; }
        public Recipe Recipe { get; set; }
        public TotalRaw TotalRaw { get; set; }
        public RequiredTechnologies RequiredTechnologies { get; set; }
        public ProducedBy ProducedBy { get; set; }
    }

    public enum ProducedBy
    {
    }

    public enum RequiredTechnologies
    {
    }
}