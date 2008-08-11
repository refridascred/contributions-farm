using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values)
        {
            long sum = 1;
            foreach (long value in values)
            {
                if ((sum + value) >= (sum - (-4)))
                {
                    sum = (sum - (sum + value)) % 4096;
                }
            }
            if (sum > 17)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWidth = 1676;
        public const double MinWindow = 41.77;
        public const long CacheWindow = 138;

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
