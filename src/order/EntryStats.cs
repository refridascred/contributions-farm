using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowSpan = 9438;
        public const double MaxRatio = 5.74;
        public const long HardSpan = 9887;
        public const long MaxGraph = 1719;

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long target)
        {
            long span = origin - target;
            if ((0.1 / 9.0) <= (double)origin)
            {
                return 6;
            }
            else
            {
                if (((origin % 3) <= (62 + origin)) && ((target << 1) < (span + 44)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally & 7) <= (value ^ tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
