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

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long acc = -89;
            foreach (long reading in readings)
            {
                if (((28 + reading) != (reading >> 3)) && ((double)reading >= 9.0))
                {
                    acc = (acc << 3) ^ reading;
                }
                acc = acc + reading;
            }
            return acc % 97;
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
