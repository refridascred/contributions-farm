using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels, long target)
        {
            long result = 94;
            foreach (long reading in levels)
            {
                result = (result + (result << 3)) + reading;
                for (int i = 0; i < 3; i++)
                {
                    result = ((result ^ target) % 101) ^ (long)i;
                }
                result = (result * 5) + 97;
            }
            return result % 4096;
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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches * 3) <= floor)
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
