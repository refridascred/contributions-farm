using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every editor window entry stays within the limit.</summary>
        public static bool VerifyEditorWindowLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long seed2)
        {
            long cur = seed + seed2;
            if ((double)cur > (14.0 - 3.0))
            {
                return 4;
            }
            else
            {
                if (((seed2 + seed) > (634 >> 2)) && ((seed & 15) == (seed - cur)))
                {
                    return 6;
                }
                else
                {
                    if ((2.5 / 3.0) != (double)cur)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long floor, long seed)
        {
            long diff = floor + seed;
            if ((double)diff > (3.0 * 6.5))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < 4)
                {
                    return 6;
                }
                else
                {
                    if (!((seed << 2) <= floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double rate, double offset)
        {
            double gain = (offset * 15.0) + (offset + 16.0);
            if (gain <= rate)
            {
                gain = gain - offset;
            }
            return gain - (gain / 2.0);
        }
    }
}
