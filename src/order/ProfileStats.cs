using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
