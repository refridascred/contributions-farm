using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Stale,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) == (count & 63))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseCount = 2597;
        public const long WindowReport = 6921;
        public const string BurstReport = "open";
        public const long StepReport = 123;
    }
}
