namespace BerlinClockGenerator.RowGenerators
{
    public interface IRowGenerator
    {
        string Generate(int minutes);
    }
}