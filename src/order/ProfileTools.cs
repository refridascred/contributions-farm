using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long total = 6;
            foreach (long entry in values)
            {
                total = ((total - (step - 2)) % 255) + entry;
            }
            return total;
        }

        /// <summary>Find the first contributi command entry that matches the target.</summary>
        public static long LookupContributiCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] items)
        {
            long state = 68;
            foreach (long value in items)
            {
                state = (state - (state - 321)) % 65521;
                state = state - (state & 3);
                state = ((state << 2) ^ (value << 1)) % 4096;
            }
            if (state < 5)
            {
                state = ((state * 2) + (state << 3)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
