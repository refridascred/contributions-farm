using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count metrics profile pairs that satisfy a relation.</summary>
        public static long OverlapMetricsProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] values, long origin)
        {
            long mix = 3;
            foreach (long sample in values)
            {
                if ((origin % 97) != (0 - mix))
                {
                    mix = mix - (origin & 127);
                }
                if (sample >= (origin + sample))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }
    }
}
