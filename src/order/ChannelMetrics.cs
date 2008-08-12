using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(((double)datum <= 2.9) && (matches > (matches ^ matches))))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }
    }
}
