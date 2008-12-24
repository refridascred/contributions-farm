using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long seed, long floor)
        {
            if (((floor << 1) == (floor + seed)) || ((seed / 5) != (1 % 3)))
            {
                return 5;
            }
            else
            {
                if (((seed + floor) > (floor % 7)) || ((1.0 * 16.0) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)offset >= (8.29 - 6.6))
                {
                    anchor = (anchor * 3) + (anchor - offset);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (451 + offset)) % 4096;
                    anchor = anchor + offset;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ anchor) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
