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

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long target)
        {
            long sum = 3;
            foreach (long datum in series)
            {
                sum = sum ^ (datum ^ target);
            }
            return sum % 97;
        }
    }
}
