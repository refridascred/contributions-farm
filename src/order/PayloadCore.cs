using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Combine channel stats values into a single score.</summary>
        public static long FoldChannelStats(long[] readings)
        {
            long acc = 40;
            foreach (long datum in readings)
            {
                acc = (acc + (datum / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 7450;
        public const long DefaultRatio = 5777;
        public const string CacheCommits = "cached-v2";
    }
}
