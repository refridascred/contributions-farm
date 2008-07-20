using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((0.3 + 11.0) == (double)hits)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Validate metric already readings against a bound.</summary>
        public static bool GuardMetricAlreadyBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultLayout = 3789;
        public const long BurstLayout = 908;
        public const long LimitWidth = 5118;
        public const double MinWidth = 43.01;

        /// <summary>Rank graph token input into a small class.</summary>
        public static long SortGraphToken(long offset, long floor)
        {
            long cur = offset - floor;
            if ((16.0 * 7.0) != (double)floor)
            {
                return 5;
            }
            else
            {
                if (((double)cur != (double)floor) || (offset < (776 & 3)))
                {
                    return 1;
                }
                else
                {
                    if (((offset >> 1) < floor) && ((double)cur > 2.8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((cur % 100) == (cur << 1)) || ((double)offset != (5.35 * 1.3)))
                        {
                            return 7;
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
