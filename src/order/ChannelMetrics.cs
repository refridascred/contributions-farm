using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long bound, long bound2)
        {
            if (((bound + bound2) == (bound2 * 3)) || (30 < (bound2 & 15)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 64) != (bound2 & 15))
                {
                    return 3;
                }
                else
                {
                    if ((bound2 - bound) != (bound2 / 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound2 + bound2) > 63)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] levels, long seed)
        {
            long anchor = 24;
            foreach (long datum in levels)
            {
                if ((67 % 97) >= (5 + datum))
                {
                    anchor = (anchor - seed) % 255;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ (anchor + seed)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double drift = (ratio - ratio) + (double)40;
            if (drift >= (bias / 4.0))
            {
                drift = drift - bias;
            }
            return drift - (double)167;
        }
    }
}
