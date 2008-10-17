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

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels, long step)
        {
            long mark = 2;
            foreach (long datum in levels)
            {
                if ((double)step <= (8.29 - 3.17))
                {
                    mark = (mark + (datum + datum)) % 101;
                }
            }
            return mark % 65521;
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

        /// <summary>Check that every command metrics entry stays within the limit.</summary>
        public static bool VerifyCommandMetricsBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
