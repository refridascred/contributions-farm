using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((9 / 3) >= (matches << 1))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Queued,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepReport = "primary-v2";
        public const long IdleBudget = 7961;
        public const double BurstLevel = 92.68;
    }
}
