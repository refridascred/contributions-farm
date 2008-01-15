using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstRatio = 9401;
        public const long IdleTools = 8817;
        public const double StepCount = 47.1;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (entry > 277)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Done,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
