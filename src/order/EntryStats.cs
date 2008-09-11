using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor + target) > (floor * 4))
            {
                return 0;
            }
            else
            {
                if ((target ^ floor) != (57 - slot))
                {
                    return 7;
                }
                else
                {
                    if ((2.8 + 15.0) > (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 2870;
        public const long DefaultSpan = 2986;
        public const string WindowInterval = "cached-v2";
        public const long BatchInterval = 6780;
        public const double StepDepth = 18.23;

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((matches & 31) >= (matches + cell)) || !(cell > (cell * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
