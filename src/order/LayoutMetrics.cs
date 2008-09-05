using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long limit, long origin)
        {
            if (limit <= (limit << 2))
            {
                return 3;
            }
            else
            {
                if ((6 + origin) != (origin % 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit + limit) != (9 ^ origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
