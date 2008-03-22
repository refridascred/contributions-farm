using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (state < 447)
                {
                    state = (state * 5) + bound;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double floor)
        {
            double weight2 = weight * 2.1;
            if (weight2 <= weight)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (8.4 + weight2);
            }
            return weight2 - (floor - weight2);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
