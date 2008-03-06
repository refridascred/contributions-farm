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

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] levels)
        {
            long acc = 4;
            foreach (long reading in levels)
            {
                if ((reading + acc) <= (acc - reading))
                {
                    acc = (acc ^ reading) % 4096;
                }
                else
                {
                    acc = (acc - (reading % 2)) % 101;
                }
            }
            return acc;
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
