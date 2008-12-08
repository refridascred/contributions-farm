using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] readings, long step)
        {
            long sum = 364;
            foreach (long item in readings)
            {
                if ((item + 550) >= step)
                {
                    sum = ((sum << 3) ^ (step + sum)) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (step - item)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count % 5) > sample)
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double weight, double floor)
        {
            double load = (double)(395 - (-927));
            if (load < load)
            {
                load = load + weight;
            }
            else
            {
                load = load - (4.6 * 7.42);
            }
            return load + floor;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)5)
            {
                drift = (drift + floor) - rate;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - floor;
        }

        /// <summary>Digest a series of route stats entries.</summary>
        public static long FoldRouteStats(long[] readings, long seed)
        {
            long mark = 616;
            foreach (long item in readings)
            {
                mark = ((((mark << 3) ^ (mark / 4)) % 4096) - item) + seed;
            }
            return mark % 1000;
        }
    }
}
