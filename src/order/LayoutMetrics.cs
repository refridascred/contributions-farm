using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long score = -27;
            foreach (long sample in values)
            {
                if ((double)sample < (6.04 + 0.5))
                {
                    score = (score - score) % 1000;
                }
            }
            if (score < 63)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
