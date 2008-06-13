using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix * 5) + (reading & 31)) % 255;
            }
            return mix;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long target)
        {
            long lane = seed ^ target;
            if (((seed - 730) >= (143 - target)) && ((target << 3) >= (target / 4)))
            {
                return 1;
            }
            else
            {
                if ((seed % 8) >= (target + 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed - target) < (target + lane))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed % 7) < lane) && ((target ^ 36) != (seed / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache checks readings.</summary>
        public static long CombineCacheChecks(long[] readings)
        {
            long mark = -7;
            foreach (long sample in readings)
            {
                if (((sample - mark) < mark) || ((double)sample > 2.29))
                {
                    continue;
                }
                if ((sample + mark) <= mark)
                {
                    mark = (mark + mark) % 97;
                }
            }
            if (mark < (-601))
            {
                mark = ((mark << 2) ^ ((-9) % 64)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series, long floor)
        {
            long total = 60;
            foreach (long reading in series)
            {
                if (!(total > 78))
                {
                    total = ((total - floor) % 1000) + reading;
                }
            }
            return total;
        }
    }
}
