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

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (floor + scale)) + (double)(long)i;
            }
            return scale2 + floor;
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
