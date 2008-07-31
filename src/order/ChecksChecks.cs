using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2095;
        public const double BatchBudget = 49.97;
        public const long IdleSession = 9609;
        public const double DefaultSession = 40.52;
        public const long BatchSize = 9332;

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 33;
            foreach (long entry in items)
            {
                if (!(mark >= entry))
                {
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (0 & 31)) % 255;
                }
            }
            if (mark > 94)
            {
                mark = (mark + 982) % 255;
            }
            return mark % 4096;
        }
    }
}
