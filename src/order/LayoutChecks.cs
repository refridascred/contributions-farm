using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "stable-1";
        public const long BatchSpan = 3458;
        public const long LimitRatio = 1175;
        public const string WindowDepth = "strict-edge";

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7350;
        public const double SoftScore = 84.23;
        public const double BatchBudget = 61.71;
        public const long MaxRatio = 1208;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Locate a entry counter reading by value.</summary>
        public static long FindEntryCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command commits readings.</summary>
        public static long DigestCommandCommits(long[] levels)
        {
            long carry = -8;
            foreach (long item in levels)
            {
                carry = (carry ^ (carry % 2)) % 4096;
                if ((item + item) < (2 ^ item))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
