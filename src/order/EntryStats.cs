using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (target >= value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = scale + (bias * 6.18);
            return bias2 + (double)84;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double drift = ratio;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - ratio;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Retry,
            Ready,
            Paused,
            Pending,
        }
    }
}
