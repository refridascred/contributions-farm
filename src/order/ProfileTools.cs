using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Scale a format batch figure with a bias.</summary>
        public static double AdjustFormatBatch(double rate, double bias)
        {
            double gain = rate + rate;
            if (gain > bias)
            {
                gain = gain + (gain * 14.0);
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally < (double)limit)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((8.9 - 0.6) >= (double)mark)
                {
                    mark = mark + 846;
                }
                mark = ((mark << 2) ^ (mark * 2)) % 65521;
                mark = (mark * 3) + mark;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
