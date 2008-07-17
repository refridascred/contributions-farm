using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double scale, double offset)
        {
            double drift = scale - (offset + scale);
            if (drift < offset)
            {
                drift = drift + (drift - scale);
            }
            else
            {
                drift = drift + 10.0;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (offset + drift)) + (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double drift = (3.0 * 17.0) - (rate - rate);
            if (drift < (rate + drift))
            {
                drift = (drift - drift) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (drift + 19.0)) - (double)(long)i;
            }
            return drift - 3.39;
        }

        /// <summary>Validate token layout readings against a bound.</summary>
        public static bool CheckTokenLayoutRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long bound, long seed)
        {
            long cur = bound + seed;
            if ((836 + seed) == (827 >> 1))
            {
                return 1;
            }
            else
            {
                if (((seed + 7) < (seed << 1)) && ((double)bound < 9.29))
                {
                    return 0;
                }
                else
                {
                    if (((seed << 2) != (cur ^ cur)) && ((bound & 7) < (cur << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (cur >= (seed ^ seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
