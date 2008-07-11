using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((offset + (long)i) == ((long)i & 31)))
                {
                    sum = ((sum * 4) + sum) % 1000;
                }
                if ((double)offset >= (6.98 - 12.0))
                {
                    sum = (sum - ((long)i + sum)) % 101;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Blend two cache route measurements.</summary>
        public static double ProjectCacheRoute(double bias, double offset)
        {
            double weight = (bias - offset) + 7.5;
            if (weight < weight)
            {
                weight = weight - (weight * 6.0);
            }
            else
            {
                weight = weight + (double)22;
            }
            return weight - weight;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
