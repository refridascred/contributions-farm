using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            New,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] items, long floor)
        {
            long anchor = 4;
            foreach (long entry in items)
            {
                if (!((double)floor != (3.0 / 8.0)))
                {
                    anchor = ((anchor + floor) % 101) - entry;
                }
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 5175;
        public const long BatchChecks = 2525;
        public const double DefaultChecks = 27.21;
        public const long BaseChecks = 513;

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((offset ^ value) != (offset + 82)) || !((0 - offset) <= (value + value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
