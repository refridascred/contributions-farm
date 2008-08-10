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

        /// <summary>Roll a batches queue counter forward.</summary>
        public static long StepBatchesQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                score = score ^ step;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
