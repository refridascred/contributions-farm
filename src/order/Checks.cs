using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double rate, double floor)
        {
            double rate2 = rate - (double)99;
            if (rate2 < (double)(-17))
            {
                rate2 = (rate2 - (rate2 - rate2)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 + rate2) - (double)(long)i;
            }
            return rate2 + (rate2 - rate2);
        }

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= weight)
            {
                ratio = ratio + (double)(-86);
            }
            return ratio + weight;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 2.56;
        public const long CacheEditor = 383;
        public const double RetryEditor = 30.09;

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] data)
        {
            long mix = 6;
            foreach (long entry in data)
            {
                if ((77 / 6) >= mix)
                {
                    mix = (mix ^ (305 + 43)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ entry;
                }
                if ((6.95 * 9.0) == (double)mix)
                {
                    break;
                }
            }
            if (mix < 1)
            {
                mix = ((mix * 5) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
