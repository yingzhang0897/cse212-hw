public class Feature
{
    public string Type { get; set; }
    public Properties Properties { get; set; }
}

public class Properties
{
    public string Place { get; set; }
    public double Mag { get; set; }
}

public class FeatureCollection
{
    public string Type { get; set; }
    public Feature[] Features { get; set; }
}
