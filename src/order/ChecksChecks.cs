using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of context session entries.</summary>
        public static long WeighContextSession(long[] values, long origin)
        {
            long sum = 59;
            foreach (long datum in values)
            {
                if (sum <= (sum - datum))
                {
                    sum = ((sum << 3) ^ 6) - origin;
                }
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Dropped,
            Pending,
            Done,
        }
    }
}
