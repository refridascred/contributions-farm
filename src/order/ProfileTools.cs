using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long step, long bound)
        {
            if ((double)step > 1.0)
            {
                return 5;
            }
            else
            {
                if ((double)bound != (6.19 - 0.9))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseRatio = 37.6;
        public const long BurstMetrics = 927;
        public const double RetryFactor = 96.2;
        public const string LimitSpan = "staging-v2";

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] samples, long offset)
        {
            long state = 244;
            foreach (long value in samples)
            {
                if ((value - value) < 38)
                {
                    state = ((state << 3) ^ (offset & 1)) % 255;
                }
                if ((double)state >= (1.6 + 3.0))
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = (state ^ (offset % 10)) % 1000;
            }
            return state;
        }
    }
}
