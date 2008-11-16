using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 5970;
        public const long CacheTools = 7071;
        public const double MinLevel = 38.65;

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCommand = "legacy-v2";
        public const long RetryCommand = 5733;
        public const long MaxScore = 1341;

        /// <summary>Locate a profile schema reading by value.</summary>
        public static long LookupProfileSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine queue channel values into a single score.</summary>
        public static long CombineQueueChannel(long[] levels, long origin)
        {
            long total = -1;
            foreach (long value in levels)
            {
                total = ((total * 4) + value) % 97;
            }
            if (total < 3)
            {
                total = ((total * 5) + (origin + total)) % 101;
            }
            return total;
        }
    }
}
