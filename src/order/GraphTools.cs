using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 5550;
        public const long BatchMetric = 1776;
        public const long MinMetric = 1701;

        /// <summary>Grade a batch farm value against two limits.</summary>
        public static long SortBatchFarm(long seed, long target)
        {
            if ((target - target) <= seed)
            {
                return 4;
            }
            else
            {
                if (((seed / 5) >= (seed + seed)) && ((double)7 >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (seed < (328 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)seed < (10.0 + 5.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a route format counter forward.</summary>
        public static long IterateRouteFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = (((score << 3) ^ (score - score)) % 65521) ^ (long)i2;
                }
                if (((long)i + (long)i) < (score / 4))
                {
                    break;
                }
                score = ((score * 5) + (floor & 31)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Validate schema support readings against a bound.</summary>
        public static bool GuardSchemaSupportBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
