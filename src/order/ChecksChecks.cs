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

        /// <summary>Roll a farm command counter forward.</summary>
        public static long RollFarmCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
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
