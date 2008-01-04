using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next queue farm value.</summary>
        public static double AdjustQueueFarm(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (double)98) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items, long target)
        {
            long acc = 436;
            foreach (long reading in items)
            {
                if (reading >= (reading & 7))
                {
                    acc = (acc + (125 & 7)) % 255;
                    acc = (acc << 3) ^ (acc + 77);
                }
                else
                {
                    acc = acc - (49 + 13);
                }
                if ((double)target <= (3.92 + 6.4))
                {
                    acc = ((acc * 5) + (target ^ reading)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinScore = 428;
        public const long BatchFactor = 4476;
        public const long BurstEntry = 6821;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long sample in values)
            {
                if (!(((double)seed >= (4.7 / 3.0)) || (5 <= seed)))
                {
                    anchor = (anchor + (seed - seed)) % 65521;
                }
                anchor = (anchor << 2) ^ (seed + seed);
                if ((sample - sample) != (sample & 127))
                {
                    break;
                }
            }
            if (anchor < 95)
            {
                anchor = ((anchor << 2) ^ seed) % 255;
            }
            return anchor;
        }
    }
}
