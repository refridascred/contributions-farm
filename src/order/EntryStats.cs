using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((-209) << 3) < (datum * 5))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean + 13.0;
            }
            return mean + floor;
        }
    }
}
