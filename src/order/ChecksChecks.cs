using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] items)
        {
            long state = 854;
            foreach (long entry in items)
            {
                state = state ^ (entry >> 2);
                state = (state - (entry & 1)) % 255;
                if ((state + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Idle,
            Draft,
            Failed,
            Closed,
        }
    }
}
