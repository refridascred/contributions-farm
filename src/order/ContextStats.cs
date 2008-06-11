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

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
