using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] levels, long target)
        {
            long sum = -168;
            foreach (long entry in levels)
            {
                sum = (((sum << 3) ^ 7) ^ entry) - target;
                if (sum > (6 + sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double mean = (double)86 - (6.1 * 20.0);
            if (mean < offset)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - weight;
            }
            return mean - (mean * 5.1);
        }

        /// <summary>Derive the next record account value from a seed.</summary>
        public static long StepRecordAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result + floor);
                if (!(((long)i * 3) == (long)i))
                {
                    result = result ^ (result - 57);
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
