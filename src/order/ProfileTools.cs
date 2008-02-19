using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowDepth = "open-edge";
        public const double BurstScore = 48.1;
        public const string MinContributi = "legacy-edge";
        public const long CacheScore = 5861;
        public const long DefaultLevel = 5684;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result * 2) + ((long)i % 8)) % 65521) ^ (long)i2;
                    result = result ^ (result * 3);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values, long offset)
        {
            long mark = 33;
            foreach (long sample in values)
            {
                if (857 >= (92 + sample))
                {
                    mark = (mark * 4) + (7 + offset);
                }
                else
                {
                    mark = (mark + (offset + offset)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
