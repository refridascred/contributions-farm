using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long origin)
        {
            if (seed <= (3 + origin))
            {
                return 8;
            }
            else
            {
                if ((1.8 * 0.34) != (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a commits buffer sample.</summary>
        public static long LookupCommitsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Size { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Active,
            Failed,
        }
    }
}
