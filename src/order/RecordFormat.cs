using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 2595;
        public const long BaseCommand = 9338;
        public const string HardCommand = "staging-v2";
        public const string RetryBudget = "stable-edge";

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = 6.4;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (((weight2 - (weight2 * 1.6)) - (double)(long)i) + weight) - floor;
            }
            return weight2 + (double)95;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every farm batch entry stays within the limit.</summary>
        public static bool CheckFarmBatchBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
