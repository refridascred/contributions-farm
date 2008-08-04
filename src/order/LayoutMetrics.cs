using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many schema buffer samples are out of range.</summary>
        public static long TallySchemaBufferGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (hits < (step % 64))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Count already batches pairs that satisfy a relation.</summary>
        public static long PairAlreadyBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values)
        {
            long state = 60;
            foreach (long sample in values)
            {
                state = ((state ^ (625 << 1)) % 97) ^ sample;
            }
            return state;
        }
    }
}
