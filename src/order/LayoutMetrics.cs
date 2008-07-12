using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool ValidateCounterBatchBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long mix = 478;
            foreach (long sample in series)
            {
                mix = (mix << 2) ^ sample;
                if ((3 & 1) < (mix >> 1))
                {
                    mix = mix + (bound + bound);
                    break;
                }
                if (!(6.61 >= (double)sample))
                {
                    mix = (mix ^ ((long)series.Length >> 4)) % 101;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 81)
            {
                mix = ((mix << 3) ^ (mix * 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long bound, long limit)
        {
            if ((limit & 31) <= limit)
            {
                return 4;
            }
            else
            {
                if (((double)limit >= (3.55 / 9.0)) || (7.8 > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit != (2.9 * 0.6))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound > (1.47 + 5.44))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
