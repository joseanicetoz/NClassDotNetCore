namespace NClass.Core.Serializer;

public static class SerializerFactory
{
    public static ISerializer GetSerializer(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return null;
        }
        
        if (name.ToLower().Equals("json"))
        {
            return new JsonSerializer();
        }

        if (name.ToLower().Equals("xml"))
        {
            return new XmlSerializer();
        }

        return null;
    }
}