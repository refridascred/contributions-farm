using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double bias3 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias3 = (bias3 - (bias2 - bias)) + (double)(long)i;
            }
            return bias3 + bias;
        }

        /// <summary>Count the profile layout entries that pass the check.</summary>
        public static long AuditProfileLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally == (8.0 / 4.0))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
