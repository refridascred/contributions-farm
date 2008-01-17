using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 8440;
        public const string RetryChecks = "staging";
        public const long BatchChecks = 5327;

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
