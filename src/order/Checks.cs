using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 70.69;
        public const long MinCount = 5177;
        public const string DefaultTimeout = "standard-v2";
        public const double StepBudget = 61.45;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const double MaxLevel = 76.86;
        public const long CacheBudget = 9195;
        public const string DefaultCache = "local-v2";
        public const double BatchLevel = 39.0;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long bound)
        {
            if ((163 % 5) >= (limit << 2))
            {
                return 5;
            }
            else
            {
                if ((limit - bound) > limit)
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ 5) < limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (539 > (limit % 8))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route layout entries that pass the check.</summary>
        public static long MeasureRouteLayoutMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((3.54 / 5.0) > (double)hits)
                {
                    hits = ((hits + 2) - sample) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
