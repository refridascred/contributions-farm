using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long MeasureContributiCacheOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((8 > (datum + offset)) || !((1.0 * 1.0) > (double)offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double gain = (double)1 / 8.0;
            return ((gain - gain) + weight) + offset;
        }
    }
}
