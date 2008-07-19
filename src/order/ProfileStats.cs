using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = ((acc - acc) % 101) - value;
            }
            return acc % 97;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= gain)
            {
                bias2 = (bias2 - (bias2 - bias2)) - bias;
            }
            else
            {
                bias2 = bias2 - (double)44;
            }
            return bias2 - (double)63;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2040;
        public const long BaseBudget = 4937;
        public const long StepRatio = 2973;
        public const long HardRatio = 7935;
        public const string IdleCluster = "latest-v2";
    }
}
