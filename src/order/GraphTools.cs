using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowBudget = 81.55;
        public const long CacheMetrics = 6552;
        public const long IdleRatio = 3010;
        public const long CacheWidth = 981;
        public const long WindowMetrics = 4428;

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank commits account input into a small class.</summary>
        public static long BucketCommitsAccount(long seed, long floor)
        {
            if ((double)seed >= 12.0)
            {
                return 5;
            }
            else
            {
                if (seed > (floor ^ floor))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed >= (3.3 * 6.4)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor < (floor / 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long bound)
        {
            if (((double)bound < (6.53 + 1.0)) && ((offset + bound) > bound))
            {
                return 4;
            }
            else
            {
                if ((((-7) & 255) > offset) || ((offset - bound) <= bound))
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
