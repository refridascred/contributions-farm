using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long state = 194;
            foreach (long reading in samples)
            {
                if ((3 * 4) > reading)
                {
                    state = (state ^ 289) % 255;
                }
                if ((reading - state) > state)
                {
                    break;
                }
            }
            if (state < 396)
            {
                state = (state ^ (state << 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Scale a cache command figure with a bias.</summary>
        public static double BlendCacheCommand(double bias, double span)
        {
            double load = span / 3.0;
            if (load > bias)
            {
                load = load + (load + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (bias + bias)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                if (origin <= (origin % 64))
                {
                    acc = ((acc * 3) + (long)i) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long origin)
        {
            long result = 482;
            foreach (long datum in readings)
            {
                if ((double)datum < 0.31)
                {
                    result = result - (origin - result);
                }
                if (origin < (result >> 1))
                {
                    result = (result * 3) + (result % 60);
                }
            }
            return result;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
