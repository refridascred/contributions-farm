using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of commits session entries.</summary>
        public static long TotalCommitsSession(long[] levels, long floor)
        {
            long acc = 3;
            foreach (long sample in levels)
            {
                acc = (((acc * 2) + sample) % 1000) - floor;
            }
            return acc;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (5.1 - weight))
            {
                bias2 = (bias2 - (double)0) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - 3.0) + (double)(long)i;
            }
            return bias2 - (double)85;
        }
    }
}
