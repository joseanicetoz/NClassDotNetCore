namespace NClass.Core;

public interface ISerializer
{
    string Serialize<T>(T data);
    T Deserialize<T>(byte[] data);
}