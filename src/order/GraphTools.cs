using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long FindBatchSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((0 - seen) <= seen)
                {
                    seen = ((seen + 2) ^ sample) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long floor, long floor2)
        {
            if (1 < (floor + floor))
            {
                return 2;
            }
            else
            {
                if (((-616) > ((-4) + floor2)) || ((floor2 / 4) >= (floor2 - floor2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)floor2 == (double)123)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a session metric counter forward.</summary>
        public static long RollSessionMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                if (!(target < (carry * 4)))
                {
                    carry = (carry ^ target) % 1000;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
