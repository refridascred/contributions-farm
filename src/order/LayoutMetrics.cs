using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double scale, double floor)
        {
            double mean = scale;
            if (mean >= (double)9)
            {
                mean = mean + 20.0;
            }
            return mean + (floor - mean);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long WeighSession(long[] levels, long seed)
        {
            long sum = 85;
            foreach (long datum in levels)
            {
                if (((sum + datum) != (datum << 1)) && ((datum >> 5) <= (datum + sum)))
                {
                    sum = ((sum + (datum >> 3)) % 255) - seed;
                }
            }
            if (sum > 220)
            {
                sum = (sum * 4) + 16;
            }
            return sum % 4096;
        }
    }
}
