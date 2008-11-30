using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up farm samples.</summary>
        public static long CompareFarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            long slot = offset + seed;
            if (slot < (81 >> 1))
            {
                return 4;
            }
            else
            {
                if ((slot + offset) > (slot >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((34 >> 2) < (slot & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long floor, long step)
        {
            if ((floor >> 4) >= (15 & 63))
            {
                return 5;
            }
            else
            {
                if ((-798) > (5 - step))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
