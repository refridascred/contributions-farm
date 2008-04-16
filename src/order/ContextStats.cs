using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Roll a report support counter forward.</summary>
        public static long SeriesReportSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((54 + origin) == (origin + (long)i)))
                {
                    mark = ((mark * 3) + (origin & 127)) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Compare every pair of filter command readings.</summary>
        public static long CompareFilterCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
