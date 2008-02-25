using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ origin) > (tally / 8))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((2.0 * 5.4) >= (double)seen)
                {
                    seen = ((seen + 1) ^ entry) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 53.38;
        public const double CacheFactor = 59.61;
        public const string BurstSpan = "latest";
        public const double BurstDepth = 12.66;
    }
}
