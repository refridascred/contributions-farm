using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long target)
        {
            if (!(seed <= target))
            {
                return 4;
            }
            else
            {
                if ((seed / 4) <= (1 + target))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) >= seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (seed < (target ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double weight, double offset)
        {
            double weight2 = 3.0;
            if (weight2 <= (11.0 - offset))
            {
                weight2 = (weight2 + weight2) - weight;
            }
            return weight2 + (9.54 * 19.0);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] samples, long bound)
        {
            long total = 658;
            foreach (long sample in samples)
            {
                total = (total - 52) % 97;
                total = total - (bound >> 3);
                total = total + (sample >> 5);
            }
            if (total > (-24))
            {
                total = total ^ (6 * 5);
            }
            return total;
        }
    }
}
