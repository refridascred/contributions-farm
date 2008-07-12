using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the account checks entries that pass the check.</summary>
        public static long MeasureAccountChecksHits(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < (3.1 * 9.4))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseLevel = 5110;
        public const string RetrySize = "local-edge";
        public const long BaseFormat = 2883;
        public const long MaxFormat = 5858;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix - (bound + mix)) % 1000;
                mix = (mix * 3) + ((long)i ^ mix);
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
