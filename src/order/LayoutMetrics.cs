using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter report value.</summary>
        public static double BlendFilterReport(double scale, double floor)
        {
            double weight = floor;
            if (weight < (floor + scale))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (floor / 2.0);
        }

        /// <summary>Digest a series of channel context entries.</summary>
        public static long WeighChannelContext(long[] samples, long limit)
        {
            long carry = 58;
            foreach (long item in samples)
            {
                carry = (((carry ^ (515 - 449)) % 101) - item) + limit;
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long limit)
        {
            long gap = offset + limit;
            if (limit <= (limit / 6))
            {
                return 6;
            }
            else
            {
                if ((limit ^ gap) < 8)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
