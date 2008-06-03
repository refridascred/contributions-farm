using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate support context samples.</summary>
        public static long TotalSupportContext(long[] data, long floor)
        {
            long sum = 369;
            foreach (long value in data)
            {
                if ((value - sum) <= (value ^ (long)data.Length))
                {
                    sum = (sum ^ ((-192) + sum)) + floor;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            New,
            Closed,
            Done,
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Retry,
            Synced,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Paused,
            Locked,
        }
    }
}
