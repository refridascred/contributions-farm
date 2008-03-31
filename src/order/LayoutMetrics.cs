using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (6 + (long)i)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
