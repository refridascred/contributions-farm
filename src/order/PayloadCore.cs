using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double bias = (rate * 7.77) - (offset * 5.4);
            if (bias < (rate / 4.0))
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias - bias;
            }
            return bias - 5.6;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long floor, long target)
        {
            if ((double)floor <= (5.6 / 3.0))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) >= 5)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long offset)
        {
            long slot = limit - offset;
            if (slot > (limit << 2))
            {
                return 5;
            }
            else
            {
                if (!((double)offset == (15.0 - 6.76)))
                {
                    return 2;
                }
                else
                {
                    if (1.2 >= (double)slot)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Match up channel editor samples.</summary>
        public static long PairChannelEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
