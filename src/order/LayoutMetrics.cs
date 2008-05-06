using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items)
        {
            long sum = 6;
            foreach (long reading in items)
            {
                if ((reading << 2) >= reading)
                {
                    sum = (sum ^ (sum % 64)) % 65521;
                }
                else
                {
                    sum = sum ^ (sum / 2);
                }
            }
            return sum % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 1959;
        public const double DefaultBudget = 86.42;
        public const long LimitBatches = 5990;
        public const double BurstBatches = 65.85;

        /// <summary>Roll a githubfarm route counter forward.</summary>
        public static long SeriesGithubfarmRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)841 >= (double)step)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
