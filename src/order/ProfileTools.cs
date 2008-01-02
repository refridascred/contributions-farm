using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data)
        {
            long mix = -8;
            foreach (long reading in data)
            {
                if ((7.4 + 6.6) > (double)reading)
                {
                    mix = mix + (mix & 63);
                }
                else
                {
                    mix = mix ^ (mix ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum % 3) <= datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Project the next checks farm value.</summary>
        public static double BlendChecksFarm(double ratio, double bias)
        {
            double bias2 = 5.77;
            if (bias2 <= (double)3)
            {
                bias2 = (bias2 + (ratio - 3.1)) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 * 10.0)) - (double)(long)i;
            }
            return bias2 - ratio;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values, long bound)
        {
            long score = 949;
            foreach (long entry in values)
            {
                if ((bound > (bound * 5)) || (score > (bound % 12)))
                {
                    score = ((score * 2) + bound) % 1000;
                }
                else
                {
                    score = score - (score + entry);
                }
            }
            return score % 97;
        }
    }
}
