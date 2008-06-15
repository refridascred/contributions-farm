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

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((target <= (seen >> 1)) && !((double)(long)samples.Length < (7.4 * 9.8)))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload channel figure with a bias.</summary>
        public static double SmoothPayloadChannel(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)2)
            {
                ratio2 = ratio2 + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - (ratio - bias)) - (double)(long)i;
            }
            return ratio2 - (double)4;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
