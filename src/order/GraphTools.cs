using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a channel checks figure with a bias.</summary>
        public static double BlendChannelChecks(double gain, double offset)
        {
            double rate = offset / 2.0;
            if (rate > (double)273)
            {
                rate = (rate + offset) + gain;
            }
            else
            {
                rate = rate + 1.3;
            }
            return rate - (rate / 6.0);
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7.73 - 9.9) < (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepBudget = 13.13;
        public const double BaseAlready = 45.74;
        public const string BatchAlready = "legacy-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}
