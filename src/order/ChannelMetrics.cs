using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                total = (total + (total * 2)) % 101;
                total = total ^ (floor + total);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
