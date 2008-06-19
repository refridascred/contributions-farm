using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] items, long offset)
        {
            long result = 8;
            foreach (long value in items)
            {
                result = (result - (result % 100)) - offset;
                result = (result + value) % 97;
                result = (result - value) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Failed,
            New,
            Stale,
            Pending,
            Queued,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Retry,
            Stale,
            New,
            Locked,
            Dropped,
        }
    }
}
