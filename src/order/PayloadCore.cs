using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two queue layout measurements.</summary>
        public static double ProjectQueueLayout(double gain, double span)
        {
            double ratio = (double)((-49) % 16);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio - (ratio / 7.0)) + (double)(long)i) + gain) - span;
            }
            return ratio + (double)33;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 36.76;
        public const double DefaultCount = 2.8;
        public const string RetryEntry = "alpha-1";

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((origin * 2) <= (origin & 7))
            {
                return 5;
            }
            else
            {
                if ((origin * 5) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ gap) > 126)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((bound + 807) > bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter cluster readings against a bound.</summary>
        public static bool VerifyCounterClusterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
