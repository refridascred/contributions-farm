using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksGaps(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (5.9 <= (double)count)
                {
                    count = ((count + 1) ^ entry) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchDepth = 9160;
        public const long DefaultFormat = 2612;
        public const long BaseFormat = 4909;

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long acc = 678;
            foreach (long sample in items)
            {
                acc = ((acc << 3) ^ acc) % 255;
                if (!((2.4 - 4.2) <= (double)acc))
                {
                    acc = (acc * 3) + sample;
                }
                acc = acc ^ (sample % 64);
            }
            return acc;
        }

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long DeriveCommitsStats(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
