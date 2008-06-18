using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate window already samples.</summary>
        public static long TotalWindowAlready(long[] samples, long seed)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((seed - 53) <= acc)
                {
                    acc = (acc << 2) ^ (reading ^ reading);
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ (acc + acc)) % 1000;
                }
                if ((reading / 6) > (seed << 2))
                {
                    acc = ((acc << 2) ^ seed) % 1000;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double offset)
        {
            double bias2 = (double)(721 + 918);
            if (bias2 < (bias / 3.0))
            {
                bias2 = bias2 - (bias / 4.0);
            }
            else
            {
                bias2 = bias2 - (bias2 / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 + (offset * 5.13);
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
