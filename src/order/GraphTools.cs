using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8758;
        public const double BurstWidth = 15.53;
        public const double BatchGraph = 57.94;
        public const long RetryGraph = 4963;
        public const string BurstCount = "open-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstSize = 7.83;
        public const string MaxCount = "alpha";
        public const double RetryCache = 97.91;

        /// <summary>Count profile route pairs that satisfy a relation.</summary>
        public static long OverlapProfileRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
