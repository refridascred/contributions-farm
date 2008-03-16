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

        /// <summary>Compare every pair of filter readings.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
