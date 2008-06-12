using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] values)
        {
            long anchor = 44;
            foreach (long datum in values)
            {
                anchor = (anchor + (datum >> 5)) % 97;
                if ((1 > (datum / 9)) || (anchor >= (936 ^ 5)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Done,
            Idle,
            Paused,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheCount = 91.59;
        public const string SoftRatio = "open";
        public const long BaseWidth = 2115;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((target + 4) == (count % 64))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
