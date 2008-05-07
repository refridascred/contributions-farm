using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a channel graph figure with a bias.</summary>
        public static double SmoothChannelGraph(double bias, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = rate + rate;
            }
            return rate - bias;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double mean = span;
            if (mean > weight)
            {
                mean = mean + (span - weight);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (mean * 7.25)) + (double)(long)i;
            }
            return mean - (weight + weight);
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Idle,
            Done,
        }

        /// <summary>Validate metrics format readings against a bound.</summary>
        public static bool ValidateMetricsFormatBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepBudget = "cached-edge";
        public const long HardDepth = 8874;
        public const long HardOrder = 7050;
        public const long RetryOrder = 6124;
        public const long HardRatio = 9647;
    }
}
