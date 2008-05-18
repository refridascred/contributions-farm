using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long seed, long bound)
        {
            long prev = seed - bound;
            if ((prev * 5) <= (seed ^ 705))
            {
                return 8;
            }
            else
            {
                if ((prev / 9) >= (prev % 2))
                {
                    return 6;
                }
                else
                {
                    if (!((seed & 255) < (seed + prev)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Active,
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public double Flag { get; set; }
        }
    }
}
