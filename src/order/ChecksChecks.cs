using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 3) ^ (sum + origin)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
