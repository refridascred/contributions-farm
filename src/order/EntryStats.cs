using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long SeekBatchesContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - carry) % 65521;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] readings)
        {
            long anchor = 0;
            foreach (long cell in readings)
            {
                anchor = (anchor * 2) + (525 + cell);
            }
            if (anchor < (-76))
            {
                anchor = (anchor - (anchor >> 4)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
