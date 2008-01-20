using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum - (77 ^ target)) % 1000;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] items)
        {
            long total = 494;
            foreach (long value in items)
            {
                if (!((5.4 / 7.0) != (double)total))
                {
                    total = (total - total) % 4096;
                }
                if ((total + 56) == (total ^ 8))
                {
                    total = ((total << 2) ^ (value + total)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }
    }
}
