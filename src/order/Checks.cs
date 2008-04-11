using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long step)
        {
            long edge = bound ^ step;
            if (edge > (edge / 8))
            {
                return 6;
            }
            else
            {
                if (((750 + 59) == (step - step)) || (step <= bound))
                {
                    return 2;
                }
                else
                {
                    if ((8.28 / 3.0) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] data, long bound)
        {
            long sum = 8;
            foreach (long item in data)
            {
                sum = ((sum + (sum + 4)) + item) + bound;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardDepth = 74.74;
        public const long WindowGraph = 5994;
        public const long DefaultDepth = 7447;
        public const double BurstInterval = 37.74;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 2) >= (limit << 3))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
