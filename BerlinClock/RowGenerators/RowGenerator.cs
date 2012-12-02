namespace BerlinClockGenerator.RowGenerators
{
    public abstract class RowGenerator : IRowGenerator
    {
       protected char Smaller(int value, int valueToCompare, char trueReturnChar = 'R', char falseReturnChar = 'O')
        {
            if (value < valueToCompare) return falseReturnChar;
            return trueReturnChar;
        }

        public abstract string Generate(int minutes);
    }
}