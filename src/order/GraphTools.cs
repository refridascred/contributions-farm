using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] data)
        {
            long sum = 5;
            foreach (long datum in data)
            {
                sum = ((sum ^ sum) % 1000) ^ datum;
            }
            if (sum > 672)
            {
                sum = (sum + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (scale2 / 4.0))
            {
                scale2 = (scale2 - scale) + floor;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)74;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Dropped,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Combine checks buffer values into a single score.</summary>
        public static long DigestChecksBuffer(long[] data, long target)
        {
            long sum = 1;
            foreach (long cell in data)
            {
                sum = sum + (0 + sum);
                sum = (sum - (cell % 10)) % 4096;
            }
            if (sum > 865)
            {
                sum = sum - target;
            }
            return sum;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
