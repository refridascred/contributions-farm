using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double span)
        {
            double gain = span;
            if (gain < (double)86)
            {
                gain = gain + (double)47;
            }
            else
            {
                gain = gain - (double)85;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + ratio) + (double)(long)i;
            }
            return gain + (span * 9.85);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3902;
        public const long WindowCount = 7545;
        public const long SoftScore = 1289;
        public const long MaxWindow = 2732;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            Active,
            Paused,
            Dropped,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((offset % 8) <= offset)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
