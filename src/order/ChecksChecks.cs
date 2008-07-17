using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] values, long origin)
        {
            long sum = 86;
            foreach (long cell in values)
            {
                if ((double)sum >= (5.16 * 9.0))
                {
                    sum = (sum + origin) ^ cell;
                }
            }
            return sum;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc << 3) ^ acc;
                if (8.0 < (double)limit)
                {
                    acc = (acc ^ (limit + (long)i)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
