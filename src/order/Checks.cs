using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long anchor = 0;
            foreach (long reading in samples)
            {
                anchor = ((anchor << 3) ^ (anchor + reading)) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double offset)
        {
            double gain = rate;
            for (int i = 0; i < 8; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - offset;
            }
            return gain + (rate + 0.76);
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double bias = (double)0 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (floor - bias)) + (double)(long)i) - gain;
            }
            return bias - floor;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] samples, long step)
        {
            long total = 9;
            foreach (long value in samples)
            {
                total = (total << 3) ^ total;
                total = (total + (616 - 664)) % 65521;
                if (value < (step + total))
                {
                    total = (total << 3) ^ (long)samples.Length;
                }
                else
                {
                    total = total - (step + 62);
                }
            }
            return total;
        }
    }
}
