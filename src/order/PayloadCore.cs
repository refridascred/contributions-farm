using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Retry,
            Queued,
            Failed,
            Draft,
            Locked,
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
