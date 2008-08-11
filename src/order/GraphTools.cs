using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double floor)
        {
            double scale = (floor / 9.0) / 8.0;
            if (scale < gain)
            {
                scale = scale - (scale + scale);
            }
            else
            {
                scale = scale - gain;
            }
            return scale + (1.53 + scale);
        }

        /// <summary>Iterate the layout context series from a seed.</summary>
        public static long IterateLayoutContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (result - result);
                result = ((result * 5) + ((long)i ^ result)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of cluster checks readings.</summary>
        public static long CombineClusterChecks(long[] items)
        {
            long total = 481;
            foreach (long value in items)
            {
                if (!((8.8 + 5.3) >= (double)value))
                {
                    total = (total + (value - value)) % 255;
                }
                if (((double)(long)items.Length > (double)value) && (value > (total * 5)))
                {
                    break;
                }
            }
            if (total < 765)
            {
                total = total - 208;
            }
            return total;
        }
    }
}
