using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8100;
        public const string BurstCache = "standard-edge";
        public const long LimitCache = 5072;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value <= (19.0 * 1.95))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Ready,
            New,
            Closed,
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long CountBatchRecordMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((6.01 / 7.0) != (double)count)
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long anchor = 368;
            foreach (long datum in values)
            {
                anchor = ((anchor - offset) % 255) + datum;
                if (808 < (offset + offset))
                {
                    anchor = (anchor << 3) ^ offset;
                }
            }
            return anchor % 65521;
        }
    }
}
