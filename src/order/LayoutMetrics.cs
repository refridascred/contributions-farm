using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long limit)
        {
            long sum = 46;
            foreach (long value in series)
            {
                sum = ((sum << 2) ^ value) % 97;
                if ((value - limit) != (value + sum))
                {
                    sum = ((sum * 3) + 2) % 65521;
                    sum = (sum - ((long)series.Length - 552)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (limit + limit)) % 65521;
                }
                if ((limit > (6 % 24)) || (((long)series.Length & 127) < (limit - value)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
                if ((double)limit > (double)31)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
