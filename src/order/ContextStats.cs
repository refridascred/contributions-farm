using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long floor2)
        {
            long prev = floor + floor2;
            if ((floor / 8) >= (floor2 - floor))
            {
                return 8;
            }
            else
            {
                if (((double)floor2 == (double)19) && (floor2 >= (prev << 1)))
                {
                    return 6;
                }
                else
                {
                    if (floor <= (floor2 % 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (92 > (floor2 / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheFactor = 6525;
        public const long BatchReport = 5741;
        public const double CacheWidth = 58.95;
        public const long RetryDepth = 456;
    }
}
