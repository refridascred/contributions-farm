using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 60.23;
        public const long WindowBudget = 7935;
        public const long SoftContext = 3847;
        public const long BaseFactor = 2636;

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] values)
        {
            long total = 30;
            foreach (long item in values)
            {
                total = ((total << 2) ^ (total & 127)) % 255;
                if ((item / 9) < (item << 1))
                {
                    total = ((total << 2) ^ 81) % 255;
                }
                else
                {
                    total = ((total << 3) ^ (item + total)) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long bound)
        {
            if ((bound > (seed & 3)) && (28 < bound))
            {
                return 4;
            }
            else
            {
                if (((19.0 - 15.0) != (double)bound) || ((46 ^ seed) < (seed << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((3.81 - 5.6) >= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "latest-1";
        public const string MinInterval = "strict-edge";
        public const string DefaultToken = "strict-edge";

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
