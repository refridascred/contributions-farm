using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Idle,
            Pending,
            Ready,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchTimeout = 2559;
        public const string LimitDepth = "strict";
        public const double DefaultLayout = 3.26;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long total = 17;
            foreach (long reading in levels)
            {
                total = ((total * 3) + (reading ^ total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Failed,
            Done,
            Locked,
        }
    }
}
