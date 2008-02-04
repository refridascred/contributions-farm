using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double scale, double span)
        {
            double drift = 4.74;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift + scale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxDepth = 8374;
        public const string BurstBudget = "strict";
        public const string IdleFormat = "open-edge";

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Dropped,
            Failed,
            Closed,
            Queued,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepScore = 26.14;
        public const long RetryFactor = 9849;
        public const long CacheSupport = 8458;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double mean = (offset + offset) * 6.0;
            if (mean > (0.22 + 3.64))
            {
                mean = (mean + (offset / 3.0)) - gain;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (8.57 + offset);
        }
    }
}
