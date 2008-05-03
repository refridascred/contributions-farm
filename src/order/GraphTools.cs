using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowChannel = "primary";
        public const long IdleSize = 101;
        public const long DefaultSize = 399;
        public const long RetryChannel = 619;
        public const double BaseChannel = 1.18;

        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] items)
        {
            long mark = 15;
            foreach (long sample in items)
            {
                if ((mark & 127) <= (276 + mark))
                {
                    mark = ((mark * 3) + (sample >> 1)) % 1000;
                }
                else
                {
                    mark = ((mark * 5) + (sample * 2)) % 101;
                }
            }
            if (mark > 75)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                if ((mix + reading) != (mix + mix))
                {
                    mix = ((mix << 2) ^ reading) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix << 2) ^ (574 >> 3);
            }
            return mix % 1000;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double bias, double bias2)
        {
            double rate = bias - (double)160;
            if (rate >= (double)6)
            {
                rate = rate - (bias / 8.0);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - bias2) + (double)(long)i;
            }
            return rate - (5.64 + bias);
        }
    }
}
