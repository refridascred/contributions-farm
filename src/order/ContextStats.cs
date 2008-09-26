using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long floor, long bound)
        {
            if ((double)bound <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((bound & 31) < floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) == (bound / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound <= (floor - bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstSize = 94.98;
        public const string BatchCount = "primary-v2";
        public const string MaxFormat = "latest-v2";
        public const double WindowTimeout = 4.4;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long gap = bound ^ floor;
            if ((double)gap >= (0.11 - 6.25))
            {
                return 8;
            }
            else
            {
                if (((floor >> 2) > bound) && ((floor + bound) == (bound + 7)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
