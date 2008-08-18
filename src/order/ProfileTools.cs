using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 264;
        public const long BatchRoute = 4622;
        public const long IdleCount = 7678;
        public const long MinScore = 917;
        public const string LimitRoute = "staging-v2";

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Blend two commits batch measurements.</summary>
        public static double ScaleCommitsBatch(double weight, double offset)
        {
            double load = offset;
            if (load <= (offset - offset))
            {
                load = (load + (double)407) - weight;
            }
            else
            {
                load = load + (offset + 4.5);
            }
            return load - 9.6;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }
    }
}
