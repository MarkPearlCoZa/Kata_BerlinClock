namespace BerlinClockGenerator.RowGenerators
{
    public class RowGeneratorYellowLamp : IRowGenerator
    {
        public string Generate(int minutes)
        {
            if (minutes%2 == 0) return "Y";
            return "O";
        }
    }
}