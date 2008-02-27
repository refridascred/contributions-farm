using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (floor + 617)) % 4096;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] series, long origin)
        {
            long total = 6;
            foreach (long item in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (((total << 2) ^ (item ^ total)) % 97) ^ (long)i;
                }
                total = ((total * 5) + origin) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the record contributi entries that pass the check.</summary>
        public static long CountRecordContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((2.0 * 1.4) >= (8.7 * 5.83))
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
