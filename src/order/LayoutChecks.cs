using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] series, long floor)
        {
            long total = -3;
            foreach (long cell in series)
            {
                total = (total + (471 / 6)) % 1000;
                if (floor >= cell)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels)
        {
            long sum = 4;
            foreach (long value in levels)
            {
                if (!!((value - value) != (value * 4)))
                {
                    sum = sum - (sum & 255);
                }
                sum = (sum ^ (sum ^ sum)) % 97;
            }
            return sum;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long target, long step)
        {
            long offset = target ^ step;
            if ((((-77) % 7) != (target / 3)) || ((offset - step) < step))
            {
                return 2;
            }
            else
            {
                if (((7.0 * 18.0) < (double)target) && ((step >> 2) < (target << 2)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long mix = 2;
            foreach (long item in series)
            {
                mix = (mix + (item ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double weight, double bias)
        {
            double gain = 8.15;
            if (gain > gain)
            {
                gain = (gain + (weight * 2.1)) - bias;
            }
            return gain + (weight / 3.0);
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
