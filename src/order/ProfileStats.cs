using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 431;
        public const long MaxSupport = 5540;
        public const string CacheInterval = "fallback-edge";

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
