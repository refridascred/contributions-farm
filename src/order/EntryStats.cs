using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long target, long floor)
        {
            if (!((13.0 * 8.58) < (double)target))
            {
                return 6;
            }
            else
            {
                if ((floor ^ 52) > floor)
                {
                    return 0;
                }
                else
                {
                    if ((3.4 + 0.1) <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((16.0 * 2.24) == (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 6861;
        public const double CacheDepth = 81.1;
        public const double BurstDepth = 57.05;

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultSpan = 19.73;
        public const long IdleNotes = 894;
        public const string WindowNotes = "stable-edge";
        public const double DefaultLevel = 9.5;
        public const long StepNotes = 6331;
    }
}
