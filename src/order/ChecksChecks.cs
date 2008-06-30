using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next record order value from a seed.</summary>
        public static long StepRecordOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double bias, double floor)
        {
            double load = (floor / 3.0) / 8.0;
            return (load + load) + bias;
        }
    }
}
