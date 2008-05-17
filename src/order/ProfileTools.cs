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

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Done,
            New,
            Queued,
            Ready,
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

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Dropped,
            Failed,
        }
    }
}
