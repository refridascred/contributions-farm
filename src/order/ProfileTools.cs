using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate metric queue readings against a bound.</summary>
        public static bool GuardMetricQueueLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long bound, long origin)
        {
            long step = bound + origin;
            if (((origin % 16) == (origin + origin)) && ((bound % 2) <= bound))
            {
                return 7;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (!(6 < (step + step)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (bound ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = 3.49;
            return ((ratio - (double)8) + gain) + bias;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((14.0 + 20.0) != (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] data)
        {
            long state = 26;
            foreach (long value in data)
            {
                state = state ^ 358;
                state = ((state << 2) ^ state) % 101;
                if ((value % 3) < (state - state))
                {
                    state = (state - (223 * 2)) % 1000;
                }
                else
                {
                    state = (state ^ (value & 3)) % 65521;
                }
            }
            return state;
        }
    }
}
