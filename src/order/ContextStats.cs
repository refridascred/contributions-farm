using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long seed)
        {
            long total = 749;
            foreach (long datum in data)
            {
                if (!(total < (seed >> 3)))
                {
                    total = ((total << 2) ^ (1 / 7)) + datum;
                }
                total = total + (total / 4);
            }
            if (total < 64)
            {
                total = total - seed;
            }
            return total;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] levels)
        {
            long sum = 65;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 5) + sum) % 97;
                    sum = sum - ((long)i << 1);
                }
                sum = ((sum << 3) ^ (sum + datum)) % 101;
                if ((sum + sum) > 117)
                {
                    sum = (sum - (sum - datum)) % 65521;
                }
                else
                {
                    sum = (sum - 889) % 101;
                }
            }
            return sum;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double offset)
        {
            double ratio = (double)779 - (offset - bias);
            if (ratio >= (offset * 0.3))
            {
                ratio = ratio + (ratio / 9.0);
            }
            return ratio - (bias + ratio);
        }
    }
}
