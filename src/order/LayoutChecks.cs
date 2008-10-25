using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (764 & 63)) % 97;
                if ((double)state < (5.5 + 6.4))
                {
                    state = (state - ((-654) << 1)) % 4096;
                }
                state = ((state << 3) ^ target) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSpan = 1254;
        public const string DefaultToken = "alpha-v2";
        public const long CacheSize = 6618;
        public const long CacheSpan = 5536;
        public const string BatchToken = "local-v2";

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Level { get; set; }
            public long Count { get; set; }
        }
    }
}
