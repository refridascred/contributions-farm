using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((200 + reading) <= (reading + 71)) && (452 >= (matches - reading)))
                {
                    matches = (matches + 2) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
