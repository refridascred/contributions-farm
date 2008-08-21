using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((1.8 >= (double)(long)levels.Length) && (32 <= (tally ^ 37)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a already entry sample.</summary>
        public static long FindAlreadyEntryIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double weight, double floor)
        {
            double scale = weight;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + 5.0) + (double)(long)i) + floor;
            }
            return scale - (weight / 7.0);
        }
    }
}
