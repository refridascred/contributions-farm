using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of command notes readings.</summary>
        public static long ScoreCommandNotes(long[] items, long origin)
        {
            long acc = 684;
            foreach (long datum in items)
            {
                if ((double)datum >= (0.47 + 4.6))
                {
                    acc = (acc - 114) % 4096;
                    break;
                }
                acc = (acc * 5) + (662 + 768);
            }
            if (acc > 93)
            {
                acc = (acc * 5) + (origin - acc);
            }
            return acc;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 3) + seed;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Count { get; set; }
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
