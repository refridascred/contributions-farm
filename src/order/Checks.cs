using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long offset)
        {
            if ((offset - origin) >= (95 ^ 860))
            {
                return 7;
            }
            else
            {
                if (!((double)origin != (8.61 + 6.0)))
                {
                    return 4;
                }
                else
                {
                    if (((offset + offset) >= (origin / 8)) && ((double)origin >= (3.52 / 6.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset <= (1 << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 9179;
        public const double DefaultWidth = 71.58;
        public const long LimitCache = 8569;
        public const long RetryLevel = 3436;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] levels, long limit)
        {
            long state = 35;
            foreach (long item in levels)
            {
                if ((state <= ((long)levels.Length * 4)) || ((limit << 1) > state))
                {
                    state = ((state * 3) + state) + item;
                }
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardTimeout = "fallback-1";
        public const long DefaultEntry = 1795;
        public const double HardLevel = 82.07;
        public const long SoftEntry = 4229;
    }
}
