using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Pending,
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 9716;
        public const long BurstContext = 1954;
        public const double CacheContext = 82.24;
        public const string RetryContext = "fallback-edge";
        public const string MinContext = "cached-1";

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long sum = 29;
            foreach (long item in samples)
            {
                sum = (((sum * 2) + ((long)samples.Length << 3)) % 4096) - item;
            }
            if (sum > (-950))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Measure how many entry payload samples are out of range.</summary>
        public static long AuditEntryPayloadHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 2) >= matches)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                if ((3.0 + 5.71) > (double)acc)
                {
                    acc = ((acc << 3) ^ target) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
