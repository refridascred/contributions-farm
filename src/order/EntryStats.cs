using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits / 5) <= (hits / 6))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((4.3 * 2.47) < (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long DigestSessionBatches(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (state >= (state << 2))
                {
                    state = ((state << 3) ^ (state + datum)) % 4096;
                }
            }
            if (state < 562)
            {
                state = ((state << 2) ^ (state & 3)) % 65521;
            }
            return state;
        }
    }
}
