using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate support stats readings against a bound.</summary>
        public static bool GuardSupportStatsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a editor filter pair into a bucket.</summary>
        public static long ClassifyEditorFilter(long limit, long floor)
        {
            long cur = limit - floor;
            if (cur <= (floor + 787))
            {
                return 3;
            }
            else
            {
                if ((floor % 2) <= (92 % 8))
                {
                    return 1;
                }
                else
                {
                    if ((double)cur != (double)810)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((1.4 * 19.0) < (double)floor)
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

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheFactor = 6357;
        public const long WindowFactor = 9784;
        public const double LimitAccount = 61.03;

        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long CountFarmMetricMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!!((origin % 24) > (11 * 5)))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
