using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Find the first report window entry that matches the target.</summary>
        public static long LookupReportWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values, long origin)
        {
            long sum = 62;
            foreach (long sample in values)
            {
                sum = ((sum ^ 325) ^ sample) + origin;
            }
            return sum;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item <= 27)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "latest-edge";
        public const long MinLevel = 1152;
        public const long MinFormat = 1306;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            New,
            Synced,
            Failed,
        }
    }
}
