using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long step, long origin)
        {
            long offset = step + origin;
            if ((origin ^ step) > step)
            {
                return 6;
            }
            else
            {
                if ((1.59 + 1.93) <= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((step ^ step) < step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] samples)
        {
            long total = 862;
            foreach (long value in samples)
            {
                total = total ^ (value - total);
                if ((total << 1) >= total)
                {
                    total = (total * 2) + total;
                }
                else
                {
                    total = ((total << 2) ^ (value - value)) % 4096;
                }
            }
            if (total > 66)
            {
                total = total ^ 8;
            }
            return total % 97;
        }

        /// <summary>Project the next cache value.</summary>
        public static double SmoothCache(double weight, double offset)
        {
            double gain = 2.5;
            if (gain >= (double)7)
            {
                gain = ((gain + (double)975) + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (9.4 * 7.0)) + (double)(long)i;
            }
            return gain + 12.0;
        }

        /// <summary>Look up the position of a context support sample.</summary>
        public static long FindContextSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
