using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Synced,
            Draft,
            New,
        }

        /// <summary>Measure how many githubfarm batch samples are out of range.</summary>
        public static long CountGithubfarmBatchGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!!((double)seen < 18.0))
                {
                    seen = ((seen + 2) - entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Size { get; set; } = "";
            public double Token { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long SeriesLayoutBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = mark + (736 + floor);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
