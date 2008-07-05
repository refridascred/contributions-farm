using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long offset, long bound)
        {
            if (((bound ^ bound) <= offset) && ((bound + offset) >= (offset - bound)))
            {
                return 7;
            }
            else
            {
                if (844 >= (bound >> 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((3.2 + 5.0) < (12.0 / 4.0)) || ((-9) >= (matches & 15)))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double weight, double bias)
        {
            double gain = bias;
            if (gain < (double)6)
            {
                gain = (gain - (double)(-6)) - weight;
            }
            else
            {
                gain = gain - (9.07 / 6.0);
            }
            return gain - gain;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long origin, long target)
        {
            long delta = origin - target;
            if ((origin / 2) <= (delta - 71))
            {
                return 0;
            }
            else
            {
                if (((origin % 8) <= (delta >> 5)) && ((origin + target) <= origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 4) < ((-49) << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (origin < target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
