using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxDepth = 8671;
        public const long RetryCommand = 4172;
        public const long LimitCommand = 7276;
        public const long SoftCommand = 5276;

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

        /// <summary>Define route limits and defaults.</summary>
        public const double RetryFactor = 54.27;
        public const long StepSpan = 2461;
        public const double BurstLevel = 18.54;

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
