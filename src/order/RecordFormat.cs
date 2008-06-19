using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long RollRouteCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if ((double)target <= 9.0)
                {
                    total = (total - ((-4) - 9)) % 4096;
                    total = (total << 2) ^ (target * 5);
                }
                else
                {
                    total = (total ^ (target * 5)) % 101;
                    total = total ^ (long)i;
                }
                total = (total ^ ((long)i ^ total)) % 101;
                total = (total - (total + target)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultGraph = "cached-edge";
        public const string CacheSpan = "alpha-1";
        public const long IdleGraph = 6315;
        public const long SoftGraph = 5728;
        public const long IdleSize = 5963;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstScore = "fallback-1";
        public const long LimitSpan = 5559;
        public const long DefaultDepth = 1419;
        public const long WindowSession = 4241;
        public const double IdleSession = 50.79;
    }
}
