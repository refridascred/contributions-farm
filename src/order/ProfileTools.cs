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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (!((double)floor != (3.0 / 8.0)))
                {
                    anchor = ((anchor + floor) % 101) - entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
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

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
