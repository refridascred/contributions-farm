using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            if ((floor + floor2) >= (floor2 & 1))
            {
                return 3;
            }
            else
            {
                if ((5.0 - 19.0) < (double)floor2)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor2 != (1.9 * 12.0)) && ((floor - 8) <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9 > (floor2 + floor)) && ((floor * 4) <= (floor2 - floor2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits layout entry stays within the limit.</summary>
        public static bool GuardCommitsLayoutLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((target % 3) >= 854))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleCount = "strict-1";
        public const long WindowRecord = 6181;
        public const long DefaultRecord = 9553;
        public const string BaseRecord = "fallback";
    }
}
