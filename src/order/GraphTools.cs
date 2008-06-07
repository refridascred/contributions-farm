using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a token editor value against two limits.</summary>
        public static long BucketTokenEditor(long target, long bound)
        {
            long next = target - bound;
            if (((1.8 - 4.4) == (double)target) || (242 >= (bound % 97)))
            {
                return 2;
            }
            else
            {
                if ((next % 10) == (next * 4))
                {
                    return 8;
                }
                else
                {
                    if (((6 >> 1) >= (bound & 127)) || ((target >> 1) <= next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double floor)
        {
            double gain = scale;
            if (gain < (7.31 * 18.0))
            {
                gain = gain - (scale * 9.88);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + floor) + (double)(long)i;
            }
            return gain - (floor / 7.0);
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (gain / 5.0))
            {
                rate = rate + 8.0;
            }
            else
            {
                rate = rate + (double)(-69);
            }
            return rate + (rate * 10.0);
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mark = ((mark ^ (step << 3)) % 97) + (long)i2;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    mark = ((mark + (step + step)) % 101) - (long)i3;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] data)
        {
            long total = 52;
            foreach (long item in data)
            {
                if ((double)total != (5.0 / 8.0))
                {
                    total = total + item;
                }
            }
            return total;
        }
    }
}
