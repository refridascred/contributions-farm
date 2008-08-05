using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((71 - floor) <= (count - 5))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 >= bias2)
            {
                bias3 = (bias3 + bias3) - bias;
            }
            else
            {
                bias3 = bias3 + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = (bias3 - bias2) + (double)(long)i;
            }
            return bias3 + (bias2 - 0.13);
        }

        /// <summary>Iterate the cache buffer series from a seed.</summary>
        public static long IterateCacheBuffer(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc - ((long)i % 60)) % 4096;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (((acc << 3) ^ (acc / 2)) % 101) + (long)i2;
                    acc = (acc << 2) ^ acc;
                }
                for (int i3 = 0; i3 < 11; i3++)
                {
                    acc = (((acc * 5) + (target % 2)) % 101) - (long)i3;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Locked,
            Stale,
            Idle,
        }
    }
}
