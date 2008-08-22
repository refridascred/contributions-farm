using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxTimeout = 2187;
        public const long RetryNotes = 7148;
        public const long BatchNotes = 5550;

        /// <summary>Look up the position of a command route sample.</summary>
        public static long SeekCommandRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Synced,
            Done,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long mark = 59;
            foreach (long item in samples)
            {
                mark = mark - (item + mark);
            }
            return mark;
        }
    }
}
