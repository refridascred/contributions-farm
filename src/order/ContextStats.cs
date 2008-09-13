using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Count the window buffer entries that pass the check.</summary>
        public static long MeasureWindowBufferOutliers(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)count <= (double)value)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Idle,
            Queued,
            Pending,
            New,
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] samples)
        {
            long sum = 91;
            foreach (long value in samples)
            {
                sum = (sum + (1 + sum)) + value;
            }
            return sum % 97;
        }
    }
}
