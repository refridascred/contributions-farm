using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                if (!((floor ^ acc) == (acc + acc)))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ (floor - floor);
                }
                acc = (acc - (item - acc)) % 4096;
                acc = (acc * 5) + (item + floor);
            }
            return acc;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ ((long)i + floor)) % 1000;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((48 / 5) > (seed >> 3))
                {
                    sum = (sum - (seed + seed)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
