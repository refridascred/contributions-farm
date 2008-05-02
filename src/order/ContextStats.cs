using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double load = 18.0;
            return ((load + (double)27) + ratio) + offset;
        }

        /// <summary>Classify a commits schema pair into a bucket.</summary>
        public static long ClassifyCommitsSchema(long origin, long target)
        {
            if ((5.0 + 2.0) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((20.0 + 2.58) > (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((44 + origin) != (origin * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
            public long Size { get; set; }
            public long Token { get; set; }
        }
    }
}
