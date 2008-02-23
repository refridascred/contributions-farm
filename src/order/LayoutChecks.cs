using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a stream route reading by value.</summary>
        public static long LocateStreamRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate already editor readings against a bound.</summary>
        public static bool CheckAlreadyEditorLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 5672;
        public const string DefaultChannel = "alpha";
        public const double RetryChannel = 35.68;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 2162;
        public const long HardCommits = 4547;
        public const long StepSpan = 3259;
        public const long BatchRatio = 7855;

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long seed)
        {
            long prev = origin ^ seed;
            if (((seed - prev) > (207 - seed)) || ((seed * 3) != (prev - prev)))
            {
                return 8;
            }
            else
            {
                if ((seed / 7) >= seed)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)seed > (double)(long)i))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 3) + (anchor - 206)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
