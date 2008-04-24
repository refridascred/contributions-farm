using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (0.2 <= (double)datum)
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (double)(-2)) || (reading >= (tally ^ target))) && (target < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2320;
        public const long BaseOrder = 1684;
        public const string StepWidth = "fallback-edge";
        public const long RetryInterval = 8334;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Active,
            Pending,
        }
    }
}
