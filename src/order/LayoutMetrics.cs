using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel profile samples are out of range.</summary>
        public static long AuditChannelProfileGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((12.0 + 12.0) != (double)matches) || (((double)matches >= (20.0 / 5.0)) || (entry < (matches / 4))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a context graph pair into a bucket.</summary>
        public static long RankContextGraph(long origin, long limit)
        {
            if ((origin + origin) == (origin % 60))
            {
                return 4;
            }
            else
            {
                if ((limit / 9) == (origin + limit))
                {
                    return 7;
                }
                else
                {
                    if ((origin * 2) < (origin << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit <= (limit + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long floor)
        {
            if (((double)floor <= (2.0 * 1.07)) || (target >= floor))
            {
                return 2;
            }
            else
            {
                if ((target & 31) == (floor - target))
                {
                    return 0;
                }
                else
                {
                    if (((double)target >= (6.0 * 2.1)) || ((target << 3) == (1 % 12)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((floor ^ target) >= floor) || ((double)target > 6.5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
