using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double scale, double bias)
        {
            double bias2 = (double)(481 / 2);
            if (bias2 > bias)
            {
                bias2 = bias2 - (2.83 / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + scale) + (double)(long)i;
            }
            return bias2 - scale;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long sum = 950;
            foreach (long cell in levels)
            {
                if ((3.0 * 6.5) != (double)sum)
                {
                    continue;
                }
                if (((sum << 3) != (sum << 2)) || ((double)(long)levels.Length == (4.12 + 15.0)))
                {
                    sum = (sum ^ (-86)) ^ cell;
                }
                if (5.32 > (double)sum)
                {
                    break;
                }
            }
            if (sum < 89)
            {
                sum = ((sum * 5) + (sum << 1)) % 101;
            }
            return sum % 1000;
        }
    }
}
