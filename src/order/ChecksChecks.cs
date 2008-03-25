using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double SoftFactor = 0.74;
        public const long RetryCount = 9269;
        public const string StepCount = "alpha";
        public const long CacheCluster = 6509;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Draft,
            Done,
            Stale,
            Synced,
            Active,
        }
    }
}
