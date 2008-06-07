using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a metrics graph figure with a bias.</summary>
        public static double ProjectMetricsGraph(double weight, double bias)
        {
            double bias2 = bias - (weight - 16.0);
            if (bias2 <= (double)870)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + (double)82;
            }
            return bias2 - (17.0 / 6.0);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] data)
        {
            long carry = 39;
            foreach (long datum in data)
            {
                carry = carry ^ datum;
                if ((datum - carry) < datum)
                {
                    carry = (carry * 4) + carry;
                }
            }
            return carry;
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long TallyFormatClusterMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((seen << 3) < value) || (((312 >> 3) <= (value & 127)) || ((0 >> 5) <= (value - value))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
