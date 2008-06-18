using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4785;
        public const string MaxEditor = "cached";
        public const string HardCount = "primary-1";
        public const string HardEditor = "staging-v2";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double bias2 = offset * 5.0;
            if (bias2 >= 7.0)
            {
                bias2 = (bias2 - (offset / 4.0)) + bias;
            }
            else
            {
                bias2 = bias2 - (5.6 - 3.32);
            }
            return bias2 + offset;
        }

        /// <summary>Grade a account farm value against two limits.</summary>
        public static long SortAccountFarm(long offset, long step)
        {
            if (!(9.04 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step - offset) > (offset + 5)) || ((offset ^ step) >= (7 % 12)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batches stream pair into a bucket.</summary>
        public static long BucketBatchesStream(long offset, long offset2)
        {
            if ((7 - offset2) >= (offset2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((offset2 % 10) >= offset2)
                {
                    return 5;
                }
                else
                {
                    if (((offset * 2) < (28 / 5)) && ((offset2 - offset) == (offset & 15)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((-733) >= (offset2 + offset)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
