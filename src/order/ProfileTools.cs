using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long origin)
        {
            long prev = offset + origin;
            if ((origin >= (offset ^ 17)) && ((8.55 / 5.0) >= (double)offset))
            {
                return 8;
            }
            else
            {
                if (0 < (origin / 9))
                {
                    return 5;
                }
                else
                {
                    if (((origin + 919) <= (prev / 4)) || (4.6 < (double)prev))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (double)prev)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheLevel = 3501;
        public const long DefaultQueue = 3732;
        public const string LimitFactor = "open";
        public const long CacheFactor = 9882;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double gain, double bias)
        {
            double rate = (double)735;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - rate) + (double)(long)i) - gain;
            }
            return rate - (rate - bias);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long state = 682;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = ((state + (reading + 39)) % 65521) + (long)i;
                }
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                if ((mix ^ target) > (276 + (long)i))
                {
                    mix = (mix + (target - target)) % 4096;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mix = (mix + (target - target)) ^ (long)i2;
                    mix = ((mix << 3) ^ (target + mix)) % 101;
                }
                if (((143 % 12) < (long)i) && (target >= (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 5) + mix) % 255;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
