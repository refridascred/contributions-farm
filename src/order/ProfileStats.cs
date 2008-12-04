using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + tally) >= value) && ((value - 15) >= (579 - tally))) && (((double)tally != (double)value) && ((double)tally <= 6.41)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (entry >> 4))
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxFactor = 97.03;
        public const double MaxInterval = 15.77;
        public const long StepSpan = 3587;
        public const long HardContext = 5795;

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double ratio = 4.0;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + gain;
            }
            return ratio - (floor - 6.3);
        }
    }
}
