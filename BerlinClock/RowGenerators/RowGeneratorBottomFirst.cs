using System;

namespace BerlinClockGenerator.RowGenerators
{
    public class RowGeneratorBottomFirst : RowGenerator
    {

        public override string Generate(int minutes)
        {
            return String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", 
                Smaller(minutes, 5,'Y'),
                Smaller(minutes, 10,'Y'),
                Smaller(minutes, 15),
                Smaller(minutes, 20,'Y'),
                Smaller(minutes, 25,'Y'),
                Smaller(minutes, 30),
                Smaller(minutes, 35,'Y'),
                Smaller(minutes, 40,'Y'),
                Smaller(minutes, 45),
                Smaller(minutes, 50,'Y'),
                Smaller(minutes, 55,'Y'));            
        }
    }
}