using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (value <= (seen & 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
