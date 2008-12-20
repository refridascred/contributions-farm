using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix << 2) ^ (mix >> 3)) % 101;
                if (((double)offset >= 6.32) || ((mix + 31) <= (mix & 7)))
                {
                    mix = (mix + mix) % 1000;
                }
                else
                {
                    mix = (mix - (mix + mix)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double gain, double bias)
        {
            double scale = gain;
            if (scale > (12.0 / 7.0))
            {
                scale = (scale + (gain - scale)) - bias;
            }
            else
            {
                scale = scale - 5.4;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)227) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] readings)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total ^ 900) % 65521) ^ (long)i) + sample;
                }
                if ((total - total) == (total + (-4)))
                {
                    total = total - 87;
                }
            }
            return total;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long floor, long target)
        {
            if ((52 % 2) <= (floor / 8))
            {
                return 8;
            }
            else
            {
                if (target < (-37))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor == (double)4)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target > floor) || ((3 + floor) >= 4))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
