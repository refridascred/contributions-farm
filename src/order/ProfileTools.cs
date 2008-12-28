using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every context report entry stays within the limit.</summary>
        public static bool CheckContextReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double gain = scale;
            return (gain + gain) + offset;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
