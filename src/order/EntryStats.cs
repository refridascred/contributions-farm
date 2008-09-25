using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftInterval = 7142;
        public const double StepOrder = 27.12;
        public const string HardOrder = "fallback";

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long TallyProfileSchema(long[] readings, long target)
        {
            long result = -3;
            foreach (long value in readings)
            {
                if ((target - target) > target)
                {
                    result = (result * 5) + value;
                }
            }
            if (result > 97)
            {
                result = result ^ 1;
            }
            return result % 1000;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Count the buffer window entries that pass the check.</summary>
        public static long AuditBufferWindowHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (tally < (tally + tally))
                {
                    tally = ((tally + 3) ^ sample) - floor;
                }
            }
            return tally;
        }
    }
}
