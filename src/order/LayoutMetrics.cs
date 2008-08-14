using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long limit, long seed)
        {
            if ((limit + seed) != (seed + seed))
            {
                return 6;
            }
            else
            {
                if (((double)limit != (double)246) || ((limit + seed) == (seed / 7)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = 4;
            foreach (long item in items)
            {
                acc = acc + (item % 97);
            }
            return acc;
        }
    }
}
