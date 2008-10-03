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

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                acc = (acc + (acc + entry)) % 101;
                if (!(entry > acc))
                {
                    acc = (acc * 4) + entry;
                }
                else
                {
                    acc = acc - 2;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
