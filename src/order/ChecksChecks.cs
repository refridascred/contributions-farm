using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double offset)
        {
            double weight2 = weight / 3.0;
            if (weight2 > weight)
            {
                weight2 = (weight2 - weight) - offset;
            }
            return weight2 + weight;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
