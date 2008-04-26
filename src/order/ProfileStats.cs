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

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale + (double)843;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] readings)
        {
            long total = 509;
            foreach (long datum in readings)
            {
                total = total - (datum % 97);
                if (((double)datum == (0.27 * 3.0)) && ((double)113 != (double)total))
                {
                    total = (total - datum) % 4096;
                }
                else
                {
                    total = total - (total ^ total);
                }
            }
            if (total < 4)
            {
                total = (total + (total << 3)) % 4096;
            }
            return total % 1000;
        }

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
