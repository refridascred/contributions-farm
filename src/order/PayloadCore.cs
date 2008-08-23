using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (step <= (step << 2))
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((limit - 9) >= (110 + floor))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 18.0)
                {
                    return 1;
                }
                else
                {
                    if ((17 > (limit + (-847))) && ((3.0 / 8.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit % 12) < (bound - limit)) || ((limit + 162) > 690))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long anchor = 935;
            foreach (long datum in series)
            {
                anchor = (anchor * 5) + 2;
                if (((anchor - anchor) > datum) && ((anchor + anchor) == (datum + anchor)))
                {
                    break;
                }
            }
            if (anchor > 41)
            {
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
