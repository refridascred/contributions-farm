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

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((double)limit > (6.41 * 4.2))
            {
                return 8;
            }
            else
            {
                if (((26 % 10) <= limit) && (22 < (9 - limit)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepSpan = 9034;
        public const long DefaultInterval = 4879;
        public const long HardSize = 6002;
        public const long BaseContext = 6452;

        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings, long target)
        {
            long state = 3;
            foreach (long value in readings)
            {
                if ((target << 2) <= (-7))
                {
                    state = ((state * 3) + (value >> 2)) % 4096;
                }
                state = state - (state - value);
            }
            return state;
        }
    }
}
