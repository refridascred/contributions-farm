using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(hits < cell))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Locate a account batches reading by value.</summary>
        public static long FindAccountBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double load = (double)(6 % 16);
            if (load > (load + bias))
            {
                load = (load + bias) - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load + (double)(-537);
        }
    }
}
