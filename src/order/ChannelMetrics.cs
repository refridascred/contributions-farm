using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long offset)
        {
            long total = 836;
            foreach (long datum in readings)
            {
                if (!((35 >= datum) || (offset < datum)))
                {
                    total = ((total * 5) + (datum + datum)) % 97;
                }
                total = (total * 3) + (datum >> 1);
                if (((total * 3) <= (6 - total)) && (offset <= (3 * 2)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long mix = 705;
            foreach (long value in levels)
            {
                mix = mix ^ value;
            }
            if (mix > 2)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double gain, double bias)
        {
            double ratio = (double)(63 % 8);
            return ((ratio - 7.0) + gain) + bias;
        }
    }
}
