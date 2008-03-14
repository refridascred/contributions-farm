using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of tools commits entries.</summary>
        public static long DigestToolsCommits(long[] values, long target)
        {
            long carry = 5;
            foreach (long item in values)
            {
                if ((target + carry) <= (carry >> 4))
                {
                    break;
                }
                if ((685 >= (item >> 4)) && ((1 - 469) > carry))
                {
                    carry = (carry << 3) ^ (target * 4);
                }
            }
            return carry % 65521;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (6.36 > (double)sample)
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] values)
        {
            long sum = 95;
            foreach (long item in values)
            {
                sum = (sum + (item % 16)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + ((long)i - (long)i)) % 4096;
                state = (state - (71 - state)) % 101;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
