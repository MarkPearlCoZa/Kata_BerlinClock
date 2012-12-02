using System;

namespace BerlinClockGenerator.RowGenerators
{
    public class RowGeneratorTopFirst : RowGenerator
    {       
        public override string Generate(int minutes)
        {
            return String.Format("{3}{2}{1}{0}", 
                Smaller(minutes, 20), 
                Smaller(minutes, 15), 
                Smaller(minutes, 10), 
                Smaller(minutes, 5));            
        }
    }
}