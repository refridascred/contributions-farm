using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a cluster batches reading.</summary>
        public static double ScaleClusterBatches(double gain, double offset)
        {
            double drift = (double)750 - offset;
            return (drift - drift) + gain;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Draft,
            Done,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Dropped,
            Idle,
            Active,
        }
    }
}
