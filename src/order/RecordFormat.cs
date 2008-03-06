using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-3) + sample) <= (76 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] items)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if ((17 / 7) == (item >> 4))
                {
                    sum = (sum * 3) + (sum >> 5);
                }
                else
                {
                    sum = sum - (item - sum);
                }
            }
            return sum;
        }
    }
}
