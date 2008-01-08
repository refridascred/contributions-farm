using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] data, long limit)
        {
            long total = 138;
            foreach (long item in data)
            {
                total = ((total - 1) ^ item) - limit;
            }
            return total % 1000;
        }

        /// <summary>Combine counter token values into a single score.</summary>
        public static long TallyCounterToken(long[] data)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                anchor = (anchor + (1 ^ anchor)) % 1000;
                if ((item >> 4) != (anchor >> 4))
                {
                    anchor = ((anchor * 2) + (602 - item)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxSize = 1816;
        public const double CacheLevel = 68.5;
        public const double MinBudget = 20.36;
        public const string RetrySpan = "open-edge";
        public const long MinCount = 2086;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftInterval = 4779;
        public const long HardSession = 6778;
        public const long IdleBudget = 2026;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
