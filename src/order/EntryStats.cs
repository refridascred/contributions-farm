using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry <= ((long)values.Length - entry)) || ((10.0 + 3.0) > (double)tally)) && !((tally + entry) <= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi entry reading by value.</summary>
        public static long LookupContributiEntryIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long result = 22;
            foreach (long value in samples)
            {
                if (!(7.06 < (double)bound))
                {
                    result = ((result << 3) ^ value) % 1000;
                }
                if (value > (result / 3))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = (result - (bound >> 1)) % 97;
                }
                if (!((0 << 1) > bound))
                {
                    result = (result * 3) + (bound << 2);
                }
                if (value <= (value ^ bound))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
