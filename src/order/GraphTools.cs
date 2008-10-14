using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((sample + matches) <= (sample >> 3)) || ((double)68 > (double)target))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Token { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit schema metrics readings against a rule.</summary>
        public static long AuditSchemaMetricsGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (0.5 - 6.2))
                {
                    count = (count + 1) + step;
                }
            }
            return count;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Dropped,
            Done,
            Paused,
            New,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
