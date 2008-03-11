using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Pending,
            Done,
            Paused,
            New,
        }

        /// <summary>Measure how many support counter samples are out of range.</summary>
        public static long TallySupportCounterMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (1.1 * 17.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long SortMetricsReport(long origin, long target)
        {
            long step = origin + target;
            if ((target - target) > 608)
            {
                return 8;
            }
            else
            {
                if ((950 - target) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 + origin) >= (step & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long step)
        {
            if (((-757) >> 2) >= (step + origin))
            {
                return 5;
            }
            else
            {
                if (414 < (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
