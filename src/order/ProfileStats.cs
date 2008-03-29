using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Draft,
            Ready,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Grade a format command value against two limits.</summary>
        public static long BucketFormatCommand(long floor, long seed)
        {
            if (((floor << 3) > (seed % 2)) && ((floor >> 4) >= ((-1) + seed)))
            {
                return 3;
            }
            else
            {
                if (!(floor < (seed + floor)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 4) == (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor / 8) >= (floor - floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel layout sample.</summary>
        public static long SeekChannelLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double rate, double bias)
        {
            double mean = rate + bias;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + rate) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
