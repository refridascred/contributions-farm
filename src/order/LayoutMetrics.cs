using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] levels)
        {
            long total = 1;
            foreach (long sample in levels)
            {
                if ((double)total == (8.02 + 12.0))
                {
                    total = (total * 5) + (sample + sample);
                }
            }
            return total;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Done,
            Ready,
            Paused,
            Idle,
        }
    }
}
