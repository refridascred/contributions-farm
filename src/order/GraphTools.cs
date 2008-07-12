using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the support commits series from a seed.</summary>
        public static long IterateSupportCommits(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = (total ^ (659 & 255)) % 255;
                if (bound >= (total + total))
                {
                    total = ((total * 3) + (total ^ bound)) % 255;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
