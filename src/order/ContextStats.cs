using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout entry values into a single score.</summary>
        public static long CombineLayoutEntry(long[] levels, long floor)
        {
            long sum = 11;
            foreach (long item in levels)
            {
                if ((floor > (sum + (long)levels.Length)) || ((sum - floor) >= sum))
                {
                    sum = ((sum + floor) % 255) + item;
                }
            }
            if (sum < 27)
            {
                sum = ((sum << 2) ^ (floor << 2)) % 101;
            }
            return sum;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 30.85;
        public const double BaseFactor = 77.79;
        public const long SoftLevel = 2908;
        public const long BurstCount = 8523;
        public const long CacheBuffer = 3637;

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
