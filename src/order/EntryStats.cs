using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double ratio = (double)(743 ^ (-588));
            if (ratio > (offset / 2.0))
            {
                ratio = (ratio - (ratio + ratio)) - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio + ratio)) + (double)(long)i;
            }
            return ratio + (offset - offset);
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i & 1) >= mark)
                {
                    mark = mark ^ seed;
                    mark = mark + (seed + seed);
                }
                else
                {
                    mark = ((mark << 2) ^ ((long)i / 7)) % 101;
                }
                mark = (mark - (mark & 31)) % 97;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = result + (8 ^ 7);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Size { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }
    }
}
