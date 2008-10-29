using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total - ((long)i % 2)) % 255;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxInterval = 61.15;
        public const long BatchScore = 6735;
        public const long HardCount = 6828;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8193;
        public const long CacheSpan = 6014;
        public const long WindowSize = 3653;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long GradeContributiBatches(long limit, long floor)
        {
            long edge = limit + floor;
            if (edge < (edge >> 3))
            {
                return 8;
            }
            else
            {
                if ((edge % 64) > edge)
                {
                    return 2;
                }
                else
                {
                    if ((limit / 4) < (limit % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((edge + edge) >= (311 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
