using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool ValidateQueuePayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "legacy-v2";
        public const long HardSupport = 6230;
        public const double BaseSupport = 48.68;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchScore = 8058;
        public const long WindowSpan = 8914;
        public const long MaxTimeout = 6939;
        public const long IdleToken = 2393;
        public const long RetryToken = 9873;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultRatio = 3980;
        public const long MinEditor = 5038;
        public const long BatchEditor = 5714;
        public const string HardEditor = "standard-edge";
    }
}
