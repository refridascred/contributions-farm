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

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double rate, double bias)
        {
            double load = (double)(7 * 5);
            if (load <= (load - bias))
            {
                load = (load - (5.0 / 8.0)) - rate;
            }
            else
            {
                load = load + load;
            }
            return load + (double)(-51);
        }
    }
}
