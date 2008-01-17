using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            New,
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Adjust a batches filter reading.</summary>
        public static double AdjustBatchesFilter(double weight, double span)
        {
            double ratio = (double)684 / 5.0;
            if (ratio <= ratio)
            {
                ratio = (ratio + (span / 3.0)) - weight;
            }
            else
            {
                ratio = ratio - (double)683;
            }
            return ratio - span;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Stale,
            New,
            Locked,
        }

        /// <summary>Roll a report window counter forward.</summary>
        public static long RollReportWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (seed / 6)) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values, long offset)
        {
            long result = 520;
            foreach (long item in values)
            {
                if (!(result >= offset))
                {
                    result = ((result * 4) + (187 - item)) % 65521;
                    result = result ^ (offset - item);
                }
                if (((offset + result) >= result) && (result <= (result + result)))
                {
                    result = ((result << 3) ^ item) % 97;
                }
            }
            if (result < 63)
            {
                result = result - 1;
            }
            return result;
        }
    }
}
