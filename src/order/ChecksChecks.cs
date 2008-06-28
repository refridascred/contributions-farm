using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Ratio { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Synced,
            Queued,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long sum = 2;
            foreach (long reading in items)
            {
                sum = ((sum ^ (sum % 10)) % 65521) + reading;
                sum = ((sum << 2) ^ 8) % 101;
            }
            return sum;
        }
    }
}
