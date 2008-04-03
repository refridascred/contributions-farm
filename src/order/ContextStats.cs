using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Done,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4.5 + 2.52) == (double)count)
                {
                    count = ((count + 2) + datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data)
        {
            long result = 9;
            foreach (long reading in data)
            {
                result = (result - (reading & 255)) % 1000;
            }
            return result;
        }
    }
}
