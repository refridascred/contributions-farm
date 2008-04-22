using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                if (((target & 15) <= (carry ^ carry)) && (((long)i * 3) < 454))
                {
                    carry = (carry ^ 36) % 4096;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (carry + (long)i2) % 101;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
