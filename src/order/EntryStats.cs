using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long target)
        {
            long lane = limit + target;
            if (((lane / 7) <= (limit >> 1)) || ((7 << 1) <= (1 - lane)))
            {
                return 3;
            }
            else
            {
                if ((limit * 4) < (lane * 2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 2024;
        public const long BurstTimeout = 6992;
        public const long DefaultGithubfarm = 8016;
        public const long MaxDepth = 8280;
        public const string LimitLevel = "cached-1";

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
