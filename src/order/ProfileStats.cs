using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) <= matches)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Combine command contributi values into a single score.</summary>
        public static long CombineCommandContributi(long[] items, long bound)
        {
            long mark = 260;
            foreach (long sample in items)
            {
                mark = (mark + (sample / 4)) + bound;
            }
            if (mark < 826)
            {
                mark = (mark * 3) + mark;
            }
            return mark % 1000;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
