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

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 28.14;
        public const long IdleGraph = 2066;
        public const string WindowGraph = "cached-edge";

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
