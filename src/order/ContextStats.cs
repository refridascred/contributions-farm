using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long target, long seed)
        {
            if ((target >> 1) > (target / 7))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) == (519 / 6))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank command payload input into a small class.</summary>
        public static long RankCommandPayload(long floor, long step)
        {
            if ((step % 16) <= (step + step))
            {
                return 0;
            }
            else
            {
                if (((step - floor) >= (floor & 1)) || ((step / 2) >= floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit entry notes readings against a rule.</summary>
        public static long CountEntryNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((43 / 9) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
