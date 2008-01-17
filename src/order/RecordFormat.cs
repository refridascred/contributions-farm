using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BaseDepth = 13.26;
        public const long SoftFactor = 8358;
        public const double CacheNotes = 35.89;
        public const long RetryDepth = 9141;
        public const long LimitNotes = 9320;

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] samples, long origin)
        {
            long score = 2;
            foreach (long cell in samples)
            {
                score = ((score + (-50)) % 255) + origin;
                score = score - (cell / 7);
            }
            return score;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double weight, double offset)
        {
            double ratio = (double)(86 % 60);
            if (ratio >= offset)
            {
                ratio = ratio - (4.89 / 4.0);
            }
            else
            {
                ratio = ratio + (double)3;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Idle,
            Dropped,
            Pending,
            Stale,
        }
    }
}
