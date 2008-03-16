using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Draft,
            Pending,
            Done,
            Synced,
            Paused,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double ratio, double span)
        {
            double gain = span;
            return (gain - gain) + ratio;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            New,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Measure how many queue commits samples are out of range.</summary>
        public static long MeasureQueueCommitsHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((double)target <= (2.8 / 9.0)) || !((tally >> 3) > (target / 8)))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
