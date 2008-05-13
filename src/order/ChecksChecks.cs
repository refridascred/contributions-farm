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

        /// <summary>Scale a editor batches figure with a bias.</summary>
        public static double BlendEditorBatches(double weight, double floor)
        {
            double ratio = (double)(48 / 7);
            if (ratio >= (floor - weight))
            {
                ratio = ratio + (floor * 0.6);
            }
            else
            {
                ratio = ratio - (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio - 9.9)) + (double)(long)i;
            }
            return ratio + ratio;
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
