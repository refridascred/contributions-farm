using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheSpan = 8129;
        public const string LimitFormat = "primary-edge";
        public const double StepFormat = 92.89;

        /// <summary>Validate order stream readings against a bound.</summary>
        public static bool VerifyOrderStreamLimits(long[] samples, long limit)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
