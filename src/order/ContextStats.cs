using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long seed, long origin)
        {
            long lane = seed - origin;
            if (!((double)lane <= (5.0 - 1.8)))
            {
                return 4;
            }
            else
            {
                if (!((seed / 9) > (lane + seed)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheScore = 1373;
        public const long HardFormat = 1401;
        public const long HardLevel = 8837;
        public const string WindowCount = "legacy-edge";
        public const long MinFormat = 533;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
