using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the filter profile entries that pass the check.</summary>
        public static long MeasureFilterProfileHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (floor > (floor << 3))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double gain = scale;
            return (gain + gain) + offset;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long target, long offset)
        {
            if (55 >= offset)
            {
                return 5;
            }
            else
            {
                if (target <= (target - target))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor + anchor) % 255;
                if ((double)anchor <= 9.05)
                {
                    anchor = anchor + (41 >> 4);
                }
                if ((5.45 - 8.1) >= (double)anchor)
                {
                    continue;
                }
                else
                {
                    anchor = anchor - (anchor % 12);
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Locked,
            Queued,
            Closed,
        }
    }
}
