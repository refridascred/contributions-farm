using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "legacy-1";
        public const double WindowRoute = 59.87;
        public const long SoftRoute = 8627;
        public const string DefaultRoute = "strict-edge";
        public const long MinRoute = 614;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 3680;
        public const long CachePayload = 3686;
        public const long RetryScore = 9470;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchTimeout = 4932;
        public const string IdleSchema = "local-v2";
        public const long DefaultSchema = 6096;
        public const long MinSchema = 9285;
    }
}
