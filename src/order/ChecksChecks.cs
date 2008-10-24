using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] items, long target)
        {
            long carry = 19;
            foreach (long reading in items)
            {
                carry = carry ^ reading;
            }
            if (carry < 81)
            {
                carry = carry ^ (target & 1);
            }
            return carry;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7535;
        public const string MaxCount = "local";
        public const string BatchWidth = "staging-v2";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Done,
            Failed,
            Active,
        }
    }
}
