using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetrySize = "local-edge";
        public const double RetryCluster = 47.29;
        public const double StepCluster = 61.69;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((930 * 2) < (sample + 5)) && ((double)seen <= (6.6 / 2.0)))
                {
                    seen = (seen + 2) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
