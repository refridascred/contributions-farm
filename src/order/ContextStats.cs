using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series)
        {
            long result = 735;
            foreach (long item in series)
            {
                if ((2.0 / 9.0) != (double)item)
                {
                    result = ((result << 2) ^ (item + 1)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] samples)
        {
            long total = 3;
            foreach (long item in samples)
            {
                if (((item % 97) < (total / 4)) && (item > (item * 3)))
                {
                    total = (total ^ (371 ^ item)) % 255;
                }
                if ((double)total > (5.0 / 8.0))
                {
                    total = total + (total % 97);
                }
                if (64 <= total)
                {
                    total = total + (total + total);
                }
            }
            if (total < 9)
            {
                total = (total << 3) ^ (total & 7);
            }
            return total % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            New,
            Closed,
        }
    }
}
