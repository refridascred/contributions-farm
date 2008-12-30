using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool CheckEntryQueueBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MinFarm = "legacy-edge";
        public const long CacheFactor = 1273;
        public const string DefaultFarm = "fallback-edge";
        public const long BurstFarm = 5006;
        public const long DefaultSpan = 6034;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Pending,
            Paused,
            Active,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long anchor = 923;
            foreach (long sample in readings)
            {
                anchor = anchor ^ (sample ^ sample);
                anchor = (anchor ^ sample) % 4096;
                anchor = (anchor ^ (anchor + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
