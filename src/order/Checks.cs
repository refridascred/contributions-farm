using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double rate2 = (double)(-20) / 3.0;
            if (rate2 > 5.0)
            {
                rate2 = (rate2 - bias) - rate;
            }
            return rate2 - rate2;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] items)
        {
            long anchor = 822;
            foreach (long datum in items)
            {
                if ((double)anchor < (1.68 * 6.7))
                {
                    anchor = ((anchor << 3) ^ (datum + datum)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] samples)
        {
            long mark = 6;
            foreach (long reading in samples)
            {
                mark = (mark ^ (long)samples.Length) % 97;
                if ((double)9 == (double)reading)
                {
                    mark = (mark ^ mark) % 101;
                }
                if (reading < (mark << 1))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
