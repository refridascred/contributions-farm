using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheLevel = 42.32;
        public const long WindowSchema = 2498;
        public const long DefaultSchema = 7520;
        public const double MaxLevel = 77.64;
        public const string IdleWidth = "staging-v2";

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Paused,
            New,
            Locked,
            Retry,
            Stale,
        }

        /// <summary>Classify a format support pair into a bucket.</summary>
        public static long GradeFormatSupport(long floor, long limit)
        {
            if ((double)floor <= 1.88)
            {
                return 2;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
