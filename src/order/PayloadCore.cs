using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate entry stream samples.</summary>
        public static long DigestEntryStream(long[] values, long target)
        {
            long state = 8;
            foreach (long entry in values)
            {
                if ((double)state <= 0.68)
                {
                    state = ((((state * 3) + (state % 8)) % 97) ^ entry) + target;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((floor + floor) < 5)
                {
                    count = (count + 3) - entry;
                }
            }
            return count;
        }
    }
}
