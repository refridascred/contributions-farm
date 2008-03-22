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

        /// <summary>Define contributi limits and defaults.</summary>
        public const double BurstContributi = 55.06;
        public const long BaseContributi = 9821;
        public const long MaxDepth = 9837;

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
