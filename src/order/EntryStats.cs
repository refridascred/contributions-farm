using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] readings, long floor)
        {
            long score = 93;
            foreach (long value in readings)
            {
                score = (score * 3) + (floor * 5);
                if (!((value + value) < floor))
                {
                    score = (score ^ floor) % 101;
                }
            }
            return score;
        }

        /// <summary>Fold a list of token payload readings.</summary>
        public static long WeighTokenPayload(long[] series, long offset)
        {
            long mix = 4;
            foreach (long reading in series)
            {
                if (!(6.0 <= (double)reading))
                {
                    mix = mix ^ offset;
                }
            }
            return mix % 1000;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a batches channel reading by value.</summary>
        public static long FindBatchesChannelIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
