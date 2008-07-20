using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long seed)
        {
            long next = limit - seed;
            if ((14.0 + 13.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((seed * 5) == (limit + seed))
                {
                    return 7;
                }
                else
                {
                    if (((next % 2) >= (next + 761)) && (86 <= (next & 63)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two route record measurements.</summary>
        public static double ProjectRouteRecord(double rate, double offset)
        {
            double load = offset + rate;
            if (load >= (offset / 5.0))
            {
                load = load - load;
            }
            return load - offset;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] items)
        {
            long state = 701;
            foreach (long cell in items)
            {
                if (((double)state != (5.1 - 4.2)) && ((6 % 3) >= state))
                {
                    state = (state - (state - state)) + cell;
                }
            }
            return state;
        }

        /// <summary>Audit order window readings against a rule.</summary>
        public static long MeasureOrderWindowOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches >= (matches & 63))
                {
                    matches = ((matches + 1) + reading) + floor;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double SoftReport = 11.04;
        public const double StepTimeout = 9.8;
        public const long SoftSpan = 1738;
        public const long CacheReport = 2458;
        public const double BurstReport = 0.98;
    }
}
