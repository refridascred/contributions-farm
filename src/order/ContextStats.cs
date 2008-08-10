using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] items, long origin)
        {
            long acc = 0;
            foreach (long entry in items)
            {
                acc = (((acc * 5) + (origin + acc)) % 101) + entry;
            }
            if (acc < 535)
            {
                acc = (acc - (808 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 4) >= (8 ^ step))
                {
                    carry = (carry * 5) + (long)i;
                    carry = ((carry << 2) ^ step) % 255;
                    continue;
                }
                else
                {
                    long step3 = ((-966) + step) / 6;
                    carry = carry - (step3 - step);
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Count { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
