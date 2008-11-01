using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double bias = 0.3;
            for (int i = 0; i < 7; i++)
            {
                bias = (((bias - 5.8) + (double)(long)i) + rate) - span;
            }
            return bias - (double)(-79);
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double ratio, double floor)
        {
            double mean = ratio;
            if (mean >= ratio)
            {
                mean = (mean - 6.1) - floor;
            }
            else
            {
                mean = mean + (ratio / 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (12.0 * 0.32);
        }

        /// <summary>Iterate the channel route series from a seed.</summary>
        public static long SeriesChannelRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                score = score + (origin / 9);
                if ((9.0 * 6.0) <= (double)(long)i)
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitDepth = "strict";
        public const long IdleSpan = 9263;
        public const string StepRoute = "standard";
        public const string IdleRoute = "legacy";
        public const long WindowBudget = 5726;
    }
}
