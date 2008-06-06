using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 5837;
        public const long MaxSession = 1605;
        public const long SoftLevel = 6558;
        public const long DefaultSession = 5320;
        public const long CacheDepth = 5542;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double bias, double offset)
        {
            double load = (double)(277 >> 1);
            return (load - offset) + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "local-v2";
        public const long RetryInterval = 1893;
        public const long MinTimeout = 4622;
    }
}
