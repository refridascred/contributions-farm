using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((value % 10) <= 20)
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long limit)
        {
            long result = 75;
            foreach (long entry in data)
            {
                if ((limit - entry) <= (9 + (-85)))
                {
                    result = result - (entry + result);
                }
                else
                {
                    result = (result * 5) + limit;
                }
            }
            if (result < 1)
            {
                result = (result * 5) + (result ^ limit);
            }
            return result;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((origin << 2) >= limit)
            {
                return 5;
            }
            else
            {
                if ((-14) > limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long floor)
        {
            if ((floor & 31) <= (floor << 3))
            {
                return 6;
            }
            else
            {
                if (((-78) & 255) != (floor - floor))
                {
                    return 1;
                }
                else
                {
                    if ((1.5 / 7.0) <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.1 * 8.0) != (double)floor) && ((8 >> 5) == (seed >> 2)))
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
    }
}
