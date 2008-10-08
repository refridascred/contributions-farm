using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BurstCluster = "primary-edge";
        public const long CacheCluster = 3194;
        public const long HardInterval = 5622;
        public const double DefaultSpan = 57.01;
        public const double WindowCount = 97.89;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
