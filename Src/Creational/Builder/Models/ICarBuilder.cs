namespace Builder.Models
{
    public interface ICarBuilder
    {
        void SetName(string name);
        void SetBody();
        void SetEngine();
    }
}