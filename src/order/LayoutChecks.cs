using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a editor metrics reading by value.</summary>
        public static long LocateEditorMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((14.0 * 1.89) != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseBudget = 3217;
        public const double IdleWindow = 94.49;
        public const long StepCount = 698;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 9034;
        public const long DefaultInterval = 4879;
        public const long HardSize = 6002;
        public const long BaseContext = 6452;

        /// <summary>Rank notes cache input into a small class.</summary>
        public static long GradeNotesCache(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((offset - edge) >= offset)
            {
                return 1;
            }
            else
            {
                if ((offset + edge) >= (limit + offset))
                {
                    return 0;
                }
                else
                {
                    if (edge >= (edge >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
