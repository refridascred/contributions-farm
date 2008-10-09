using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double gain, double span)
        {
            double rate = (double)(986 - 839);
            if (rate > (span + gain))
            {
                rate = rate + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)7) + (double)(long)i;
            }
            return rate - 9.07;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (tally <= (tally / 2))
                {
                    tally = ((tally + 1) ^ sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long total = 973;
            foreach (long value in levels)
            {
                if ((value - value) < value)
                {
                    total = total + (value + value);
                }
                else
                {
                    total = total + value;
                }
                if (!((double)total > (13.0 * 7.58)))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total - (total << 2);
            }
            return total;
        }
    }
}
