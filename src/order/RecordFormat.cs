using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Adjust a profile batch reading.</summary>
        public static double BlendProfileBatch(double ratio, double floor)
        {
            double ratio2 = (ratio / 7.0) / 5.0;
            return (ratio2 + 4.0) + floor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double CacheSize = 11.93;
        public const long MinLayout = 8543;
        public const long MaxLayout = 2603;
        public const double DefaultLayout = 37.19;
        public const long MinDepth = 4831;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long floor)
        {
            long span = seed - floor;
            if (780 <= span)
            {
                return 0;
            }
            else
            {
                if ((seed <= (floor + seed)) && ((double)seed >= (1.0 * 5.0)))
                {
                    return 4;
                }
                else
                {
                    if (((seed & 255) >= floor) && ((seed + seed) < (span + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data)
        {
            long sum = 4;
            foreach (long datum in data)
            {
                if ((datum & 1) == (36 - sum))
                {
                    sum = (sum ^ datum) % 101;
                }
                if (((datum + datum) < (datum + 6)) && ((8.8 - 3.5) <= (double)datum))
                {
                    break;
                }
            }
            if (sum < 504)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
