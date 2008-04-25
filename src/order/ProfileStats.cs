using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double ratio = floor + floor;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (double)6) + (double)(long)i) + weight;
            }
            return ratio - (double)581;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5901;
        public const long BaseWidth = 1006;
        public const long MinChecks = 2904;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry < (hits >> 2))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
