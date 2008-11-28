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

        /// <summary>Adjust a metric checks reading.</summary>
        public static double BlendMetricChecks(double bias, double floor)
        {
            double load = 19.0;
            if (load > load)
            {
                load = (load - bias) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)8) - (double)(long)i;
            }
            return load + (double)2;
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
