using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 6890;
        public const long CacheFilter = 6185;
        public const long WindowFilter = 324;

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultSpan = "open-edge";
        public const string IdleWidth = "latest-1";
        public const long BatchDepth = 1136;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 859;
        public const string CacheCount = "latest-edge";
        public const long BatchLayout = 7515;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long bound = origin - origin2;
            if ((3.28 + 9.1) > (double)origin2)
            {
                return 0;
            }
            else
            {
                if ((bound ^ bound) >= (origin * 3))
                {
                    return 5;
                }
                else
                {
                    if ((origin2 >> 5) < 828)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound & 7) > origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
