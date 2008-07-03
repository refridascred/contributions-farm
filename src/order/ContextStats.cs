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

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 7949;
        public const double MinCounter = 72.36;
        public const long HardCounter = 7052;
        public const long WindowTimeout = 1204;
        public const long CacheCounter = 1408;
    }
}
