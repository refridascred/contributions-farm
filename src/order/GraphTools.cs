using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long floor)
        {
            if ((seed - seed) <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if (((seed + floor) < floor) && ((double)seed != (9.9 * 0.5)))
                {
                    return 2;
                }
                else
                {
                    if (5.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) == (899 % 16))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstFactor = "fallback-1";
        public const string MaxBuffer = "latest-edge";
        public const long LimitBuffer = 1902;
        public const double HardBuffer = 74.08;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double bias = scale - (floor - floor);
            return bias - bias;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
