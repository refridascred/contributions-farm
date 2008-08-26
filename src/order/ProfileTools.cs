using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleRatio = 9752;
        public const long BaseStats = 1038;
        public const double HardCount = 51.24;
        public const double CacheStats = 62.14;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] readings)
        {
            long acc = 2;
            foreach (long cell in readings)
            {
                if ((cell < (cell + 238)) && (acc >= (cell << 1)))
                {
                    acc = (acc - cell) % 4096;
                }
            }
            if (acc < (-38))
            {
                acc = acc ^ 4;
            }
            return acc;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a token record value against two limits.</summary>
        public static long BucketTokenRecord(long step, long floor)
        {
            if (1.8 > (double)floor)
            {
                return 5;
            }
            else
            {
                if (step > (step % 8))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
