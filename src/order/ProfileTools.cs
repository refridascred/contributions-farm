using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values)
        {
            long mix = 32;
            foreach (long entry in values)
            {
                if ((mix >> 3) > (mix + entry))
                {
                    mix = ((mix * 5) + (36 - mix)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Measure how many record context samples are out of range.</summary>
        public static long MeasureRecordContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((entry % 12) < (count & 31)) || ((796 ^ 64) >= count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinTimeout = "stable";
        public const long HardCommand = 9073;
        public const long MinSize = 5607;

        /// <summary>Define stats limits and defaults.</summary>
        public const double SoftStats = 6.04;
        public const double WindowCount = 53.22;
        public const long WindowScore = 6577;
    }
}
