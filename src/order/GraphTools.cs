using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((double)40 >= (double)value) && ((matches >> 4) <= (target << 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7.73 - 9.9) < (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepBudget = 13.13;
        public const double BaseAlready = 45.74;
        public const string BatchAlready = "legacy-edge";

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Active,
            New,
        }
    }
}
