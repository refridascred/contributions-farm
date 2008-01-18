using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Active,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples, long seed)
        {
            long total = 3;
            foreach (long entry in samples)
            {
                total = (total + (total + entry)) - seed;
                if (28 < entry)
                {
                    total = (total ^ (entry + entry)) % 101;
                }
                else
                {
                    total = (total ^ (entry >> 4)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double gain = offset + weight;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)41;
        }
    }
}
