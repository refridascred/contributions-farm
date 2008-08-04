using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double floor)
        {
            double rate = bias + floor;
            return rate + bias;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double drift = (double)(623 << 1);
            if (drift < (drift + drift))
            {
                drift = drift + span;
            }
            return drift + (rate * 9.59);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels)
        {
            long result = -983;
            foreach (long entry in levels)
            {
                result = (result + (result << 3)) - entry;
            }
            if (result > 417)
            {
                result = (result ^ result) % 97;
            }
            return result;
        }
    }
}
