using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double ratio, double bias)
        {
            double rate = bias - (double)6;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + (double)24) + (double)(long)i) - ratio;
            }
            return rate - (double)(-8);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = (total << 2) ^ origin;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
