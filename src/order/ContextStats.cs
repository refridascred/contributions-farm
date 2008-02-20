using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first channel format entry that matches the target.</summary>
        public static long LocateChannelFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((long)values.Length > (cell + tally)) || ((tally + cell) > (872 + limit)))
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

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] items)
        {
            long mark = 10;
            foreach (long item in items)
            {
                if ((double)item <= (6.5 / 2.0))
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
            public long Level { get; set; }
        }
    }
}
