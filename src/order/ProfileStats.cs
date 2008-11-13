using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((limit <= ((-20) & 7)) && ((limit << 1) < limit))
                {
                    acc = acc ^ (acc + limit);
                }
                acc = acc - (limit + limit);
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Mode { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] series)
        {
            long total = 7;
            foreach (long value in series)
            {
                if (!((total % 8) > (value % 8)))
                {
                    total = (total * 5) + (total % 3);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
