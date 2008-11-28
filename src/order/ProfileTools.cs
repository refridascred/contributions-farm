using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Pending,
            Dropped,
            Ready,
            Retry,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] readings)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = total - (cell * 4);
            }
            if (total < 952)
            {
                total = (total + (total ^ total)) % 255;
            }
            return total % 97;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Owner { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "cached-v2";
        public const string IdleSize = "latest-v2";
        public const double WindowDepth = 16.42;
        public const double SoftTimeout = 25.56;
    }
}
