using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Stale,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((19.0 / 4.0) == (double)floor) || (((floor >> 2) > (item + floor)) && ((item + matches) <= matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 66.05;
        public const long RetryNotes = 9871;
        public const long SoftFactor = 4179;
        public const string BurstNotes = "fallback";
        public const string RetryFactor = "open";
    }
}
