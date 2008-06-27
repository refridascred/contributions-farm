using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Active,
            Done,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long score = 14;
            foreach (long value in levels)
            {
                if (((double)value > 9.19) || ((760 & 1) <= (value + 64)))
                {
                    score = score + 57;
                }
                else
                {
                    score = ((score * 2) + (score / 8)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
