using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Failed,
            Locked,
            Pending,
            Closed,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 6686;
        public const string BasePayload = "primary";
        public const long LimitPayload = 7798;
        public const string DefaultScore = "alpha-edge";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor + ((long)i << 1)) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
