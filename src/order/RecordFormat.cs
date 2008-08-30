using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long target, long limit)
        {
            if (!((4.0 / 6.0) >= (double)limit))
            {
                return 2;
            }
            else
            {
                if ((double)target != (8.2 * 1.5))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long offset)
        {
            long sum = 652;
            foreach (long entry in data)
            {
                if ((entry & 127) < offset)
                {
                    sum = ((sum << 3) ^ (sum & 1)) % 97;
                }
                else
                {
                    sum = ((sum << 3) ^ (offset * 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 8822;
        public const long MaxRecord = 9498;
        public const long DefaultFactor = 8845;
        public const long StepCount = 8120;

        /// <summary>Locate a queue metric reading by value.</summary>
        public static long SeekQueueMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Failed,
            Stale,
            Synced,
        }
    }
}
