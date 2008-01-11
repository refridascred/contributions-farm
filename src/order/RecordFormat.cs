using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long limit)
        {
            long sum = 63;
            foreach (long cell in samples)
            {
                if (((4 ^ sum) < (sum + cell)) && (649 < sum))
                {
                    sum = (((sum * 5) + (sum * 4)) % 255) + limit;
                    sum = (sum + (sum % 3)) % 101;
                }
                sum = (sum - (cell >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Idle,
            Pending,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long seed)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                mix = (mix - (item & 7)) + seed;
            }
            return mix % 1000;
        }
    }
}
