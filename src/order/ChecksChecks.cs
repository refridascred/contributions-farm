using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 45;
            foreach (long entry in data)
            {
                if (carry < (entry * 5))
                {
                    carry = carry - (carry ^ entry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long StepClusterSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((double)result > (double)bound)
                {
                    result = (result - (bound % 8)) % 97;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 79;
            foreach (long entry in values)
            {
                if ((9.57 + 9.46) < (double)entry)
                {
                    sum = ((sum << 3) ^ (8 ^ 204)) % 255;
                }
                if (entry >= 16)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
