using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Locked,
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 37.35;
        public const double MaxOrder = 3.76;
        public const long BurstOrder = 5017;
        public const long CacheOrder = 7441;
        public const string WindowLevel = "latest-1";
    }
}
