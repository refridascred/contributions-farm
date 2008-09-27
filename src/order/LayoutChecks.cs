using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long target)
        {
            long result = 29;
            foreach (long entry in values)
            {
                if ((3.98 * 9.0) >= (double)result)
                {
                    result = (result + result) % 255;
                }
                if ((entry - target) <= (5 ^ target))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double ratio, double bias)
        {
            double rate = ratio;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - rate) + (double)(long)i) + bias;
            }
            return rate + rate;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseInterval = 8289;
        public const double LimitStream = 0.61;
        public const long WindowTimeout = 6357;
        public const long StepRatio = 2467;
        public const string BatchLevel = "latest-v2";

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitFactor = 8.56;
        public const double WindowWidth = 88.52;
        public const double BaseFactor = 4.69;
    }
}
