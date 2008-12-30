using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine route window values into a single score.</summary>
        public static long DigestRouteWindow(long[] data, long offset)
        {
            long acc = 2;
            foreach (long entry in data)
            {
                if ((entry - 3) > (acc - acc))
                {
                    break;
                }
                acc = (acc + entry) + offset;
            }
            if (acc > 1)
            {
                acc = (acc * 5) + (acc << 3);
            }
            return acc % 65521;
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
