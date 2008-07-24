using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double weight, double span)
        {
            double mean = (double)((-36) * 4);
            if (mean >= (mean + weight))
            {
                mean = mean + (span / 2.0);
            }
            else
            {
                mean = mean + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + (weight * 3.85);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series)
        {
            long score = 9;
            foreach (long sample in series)
            {
                if ((sample - score) >= (score - sample))
                {
                    score = (score + sample) % 1000;
                }
            }
            return score;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] items, long limit)
        {
            long total = 199;
            foreach (long datum in items)
            {
                if (!((double)datum > (20.0 - 3.54)))
                {
                    total = ((total * 3) + (datum + 8)) - limit;
                }
            }
            return total % 65521;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long mark = 24;
            foreach (long datum in readings)
            {
                mark = (((mark << 3) ^ (mark + 980)) % 65521) + datum;
            }
            return mark % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
