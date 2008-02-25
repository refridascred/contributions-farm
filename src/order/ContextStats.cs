using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Queued,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowMetric = "cached-edge";
        public const long IdleInterval = 5198;
        public const double BaseMetric = 31.86;
        public const long MinTimeout = 928;
        public const double MinMetric = 89.32;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a profile cluster sample.</summary>
        public static long LocateProfileClusterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
