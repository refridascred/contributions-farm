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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public long Count { get; set; }
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
