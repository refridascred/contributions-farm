using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long acc = 188;
            foreach (long reading in samples)
            {
                if ((4.5 - 6.0) <= (double)reading)
                {
                    acc = (acc - acc) % 4096;
                }
                else
                {
                    acc = (acc - (origin - reading)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 26.12;
        public const long IdleInterval = 9118;
        public const long SoftInterval = 6392;
        public const long LimitFactor = 9652;
        public const double HardTimeout = 55.53;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 17.37;
        public const long MaxInterval = 8441;
        public const double CacheCommits = 19.57;
    }
}
