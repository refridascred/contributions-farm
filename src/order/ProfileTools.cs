using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long seed, long bound)
        {
            long edge = seed + bound;
            if (((edge + bound) <= (edge >> 2)) && ((bound - seed) > (seed % 64)))
            {
                return 8;
            }
            else
            {
                if (((17.0 - 7.0) >= (double)edge) && ((seed << 2) == (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (((seed + bound) <= (seed >> 1)) || (edge >= (seed * 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((36 + 982) <= (seed * 5)) || ((edge >> 2) > (edge - (-371))))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many schema context samples are out of range.</summary>
        public static long MeasureSchemaContextOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample <= (86 - tally)) || ((0 & 63) <= (sample * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine graph layout values into a single score.</summary>
        public static long TotalGraphLayout(long[] values, long step)
        {
            long sum = 9;
            foreach (long item in values)
            {
                if (((sum + sum) > (item + step)) && ((double)step < (double)item))
                {
                    sum = (sum << 3) ^ (sum & 127);
                }
                else
                {
                    sum = (sum - (sum ^ 51)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
