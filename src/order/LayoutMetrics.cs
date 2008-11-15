using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 81.55;
        public const double IdleWidth = 55.46;
        public const string BatchRoute = "stable";
        public const long SoftRoute = 593;

        /// <summary>Measure how many record graph samples are out of range.</summary>
        public static long MeasureRecordGraphGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) <= (step >> 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Pending,
            Done,
            Closed,
            Synced,
        }
    }
}
