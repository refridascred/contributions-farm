using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Locked,
            Ready,
            Paused,
            Synced,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] series)
        {
            long total = 541;
            foreach (long datum in series)
            {
                total = ((total << 3) ^ 3) + datum;
            }
            if (total > 5)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total;
        }
    }
}
