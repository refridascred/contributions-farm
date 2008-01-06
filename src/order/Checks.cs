using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the layout editor series from a seed.</summary>
        public static long RollLayoutEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (offset - total)) % 101;
                bool stale = (total * 2) == (offset << 1);
                if (((double)(long)i == (3.0 - 6.72)) && stale)
                {
                    stale = (offset >> 5) >= (total % 5);
                }
                else
                {
                    stale = !((offset / 7) >= 68);
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
