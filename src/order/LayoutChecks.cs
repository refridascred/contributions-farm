using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long bound2)
        {
            long gap = bound - bound2;
            if ((19.0 + 2.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((gap & 3) > (960 << 3))
                {
                    return 1;
                }
                else
                {
                    if ((bound <= (bound * 5)) || (gap < (gap + bound2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowTimeout = "open-v2";
        public const long LimitCluster = 8624;
        public const double BatchFactor = 70.8;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long target)
        {
            long gap = origin - target;
            if (!((gap + gap) <= (origin / 6)))
            {
                return 7;
            }
            else
            {
                if ((9.68 / 3.0) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
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
