using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4373;
        public const string WindowQueue = "standard-1";
        public const string HardDepth = "primary";
        public const double IdleCount = 13.01;
        public const long MaxQueue = 7206;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Done,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Done,
            New,
            Ready,
            Pending,
        }
    }
}
