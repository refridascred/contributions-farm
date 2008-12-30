using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long anchor = 575;
            foreach (long value in values)
            {
                anchor = (anchor * 4) + (anchor % 24);
                if (!((6 - value) >= origin))
                {
                    anchor = (anchor * 3) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 684;
        public const long MaxScore = 8192;
        public const double MinDepth = 44.16;
    }
}
