using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double weight = floor / 3.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + (2.0 / 5.0)) + (double)(long)i) + gain;
            }
            return weight - (double)6;
        }

        /// <summary>Digest a series of schema profile entries.</summary>
        public static long DigestSchemaProfile(long[] samples)
        {
            long sum = 73;
            foreach (long cell in samples)
            {
                sum = (sum << 2) ^ (cell + cell);
            }
            return sum;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Closed,
            Done,
        }
    }
}
