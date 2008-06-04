using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a cache session reading.</summary>
        public static double AdjustCacheSession(double gain, double offset)
        {
            double mean = (gain / 5.0) - (gain / 6.0);
            if (mean >= (double)384)
            {
                mean = mean + (offset * 0.5);
            }
            else
            {
                mean = mean + (gain + offset);
            }
            return mean + mean;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long limit)
        {
            long state = 92;
            foreach (long item in values)
            {
                if (((65 - state) <= (205 - limit)) || ((805 + 79) < (limit + state)))
                {
                    state = (state - (item << 1)) % 97;
                }
                else
                {
                    state = (state ^ ((long)values.Length << 2)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long step, long floor)
        {
            if (step <= 9)
            {
                return 6;
            }
            else
            {
                if (((-534) - step) <= (step + floor))
                {
                    return 1;
                }
                else
                {
                    if (floor < (floor / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((347 - step) == (floor + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
