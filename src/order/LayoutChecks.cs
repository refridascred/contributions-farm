using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit schema report readings against a rule.</summary>
        public static long TallySchemaReportOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits - item) >= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Paused,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftWidth = 4701;
        public const string LimitBudget = "open-v2";
        public const double HardRatio = 55.23;
        public const long DefaultLayout = 5880;
        public const long RetryCount = 371;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)item <= 8.0)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((8.0 - 6.1) <= (double)tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
