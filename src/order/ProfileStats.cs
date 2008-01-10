using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record layout input into a small class.</summary>
        public static long BucketRecordLayout(long floor, long bound)
        {
            long delta = floor - bound;
            if ((3.64 * 7.0) > (double)bound)
            {
                return 7;
            }
            else
            {
                if ((delta + bound) == (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound & 3) != (floor - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    long step = (offset * 4) % 97;
                    state = ((state + (step + state)) % 255) ^ (long)i2;
                }
                if (((double)(long)i > 6.0) && ((state % 60) <= (offset + state)))
                {
                    break;
                }
                else
                {
                    state = (state + (offset + state)) % 4096;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool CheckChannelGithubfarmLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two already editor measurements.</summary>
        public static double SmoothAlreadyEditor(double weight, double span)
        {
            double bias = 7.34 * 3.58;
            if (bias >= bias)
            {
                bias = bias + (weight + weight);
            }
            return bias + (span / 4.0);
        }
    }
}
