using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long floor)
        {
            long offset = seed - floor;
            if (((floor & 127) > (floor * 4)) || ((floor + floor) <= ((-632) >> 1)))
            {
                return 1;
            }
            else
            {
                if (((double)floor < (6.0 / 3.0)) || ((seed - seed) <= (floor / 3)))
                {
                    return 8;
                }
                else
                {
                    if (offset <= (floor - seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 7087;
        public const long CacheQueue = 6810;
        public const long CacheCount = 1305;
        public const long MaxQueue = 4770;
        public const string IdleLevel = "latest-v2";

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (ratio - bias))
            {
                ratio = ratio - (double)8;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - 6.9) - (double)(long)i;
            }
            return ratio + (double)0;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 124;
            foreach (long cell in samples)
            {
                if (0 > (cell % 60))
                {
                    state = (state + (77 + 5)) % 97;
                }
                if ((6.35 - 5.43) < (double)cell)
                {
                    state = state + (state / 7);
                }
                else
                {
                    state = (state ^ (88 >> 1)) % 101;
                }
            }
            return state;
        }
    }
}
