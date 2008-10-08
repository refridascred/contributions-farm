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

        /// <summary>Count the entry layout entries that pass the check.</summary>
        public static long TallyEntryLayoutOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count <= 1.66)
                {
                    count = (count + 2) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
