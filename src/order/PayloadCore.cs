using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate queue already readings against a bound.</summary>
        public static bool CheckQueueAlreadyRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long target, long target2)
        {
            if ((double)target > (double)target2)
            {
                return 5;
            }
            else
            {
                if ((target + target) <= (target2 + target))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value > (hits + 43)) || (((value + value) >= (hits << 3)) || (((-69) - value) >= (value % 97))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc - origin) % 255) ^ (long)i2;
                    acc = acc + (origin + origin);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
