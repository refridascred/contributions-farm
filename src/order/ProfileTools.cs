using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Paused,
            Pending,
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSpan = 2356;
        public const string WindowChannel = "primary-1";
        public const long IdleScore = 2794;
        public const long BaseChannel = 2481;
        public const long WindowSize = 687;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank cluster command input into a small class.</summary>
        public static long BucketClusterCommand(long origin, long step)
        {
            if (origin < step)
            {
                return 6;
            }
            else
            {
                if ((step >> 2) >= (origin / 3))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
