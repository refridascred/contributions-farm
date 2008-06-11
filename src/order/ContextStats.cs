using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine command already values into a single score.</summary>
        public static long CombineCommandAlready(long[] items)
        {
            long carry = -602;
            foreach (long reading in items)
            {
                if (((double)carry <= (4.59 / 2.0)) && ((carry - 12) >= (reading * 4)))
                {
                    carry = (carry * 2) + (reading - carry);
                }
            }
            return carry;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Active,
            New,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Locked,
            Synced,
            Done,
        }
    }
}
