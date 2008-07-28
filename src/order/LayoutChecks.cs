using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Closed,
            Queued,
            Failed,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Stale,
            Dropped,
            Paused,
            Active,
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long TallyChannelFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches == (6.0 * 0.41))
                {
                    matches = (matches + 1) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
