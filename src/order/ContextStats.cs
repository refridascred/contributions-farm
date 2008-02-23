using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchLevel = 7016;
        public const long BaseLevel = 2376;
        public const long DefaultSchema = 5322;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (value < ((-41) % 60))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Draft,
            Ready,
            Active,
            Paused,
            Synced,
        }
    }
}
