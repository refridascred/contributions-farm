using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next already layout value from a seed.</summary>
        public static long StepAlreadyLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 2037;
        public const double MaxLevel = 77.64;
        public const long StepMetrics = 737;

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 9282;
        public const long CacheTimeout = 6456;
        public const long MinTools = 4333;
        public const long BaseWidth = 4772;
        public const double SoftLevel = 38.13;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
