using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate schema context samples.</summary>
        public static long FoldSchemaContext(long[] levels)
        {
            long carry = 7;
            foreach (long datum in levels)
            {
                if (((8.5 + 15.0) >= (double)carry) || (datum < (3 ^ carry)))
                {
                    carry = carry + (carry - carry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double weight, double span)
        {
            double bias = weight;
            if (bias < (double)64)
            {
                bias = (bias + bias) - span;
            }
            else
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
