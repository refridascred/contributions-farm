using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 7565;
        public const string BurstSession = "standard-1";
        public const long WindowSession = 8512;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length + reading) > (9 << 1))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((((-61) + reading) >= (reading ^ count)) && ((count ^ count) != (count - 70)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Synced,
        }
    }
}
