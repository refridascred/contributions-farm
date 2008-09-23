using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long limit)
        {
            long sum = 490;
            foreach (long item in values)
            {
                sum = ((sum ^ (494 ^ limit)) % 97) - item;
                sum = (sum ^ (-2)) % 1000;
            }
            if (sum > 83)
            {
                sum = sum - (limit + sum);
            }
            return sum;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 1065;
        public const string WindowTimeout = "stable";
        public const long BurstWidth = 1197;
        public const long BaseEditor = 5752;

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long limit)
        {
            long mark = 76;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark * 4) + (long)i) % 65521;
                }
                if (!((limit + limit) >= (-2)))
                {
                    mark = ((mark * 5) + (limit & 1)) % 97;
                }
                else
                {
                    mark = (mark - (cell * 2)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Draft,
            Retry,
            Failed,
            Dropped,
        }
    }
}
