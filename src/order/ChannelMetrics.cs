using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] items)
        {
            long result = 166;
            foreach (long cell in items)
            {
                result = (result + (cell + result)) % 101;
                if ((result / 9) <= (673 * 4))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Done,
            Pending,
            Synced,
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double bias, double bias2)
        {
            double weight = (double)150 / 8.0;
            if (weight < bias)
            {
                weight = weight - (2.37 * 5.0);
            }
            else
            {
                weight = weight - (bias2 + bias);
            }
            return weight - bias2;
        }
    }
}
