using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of githubfarm entry entries.</summary>
        public static long FoldGithubfarmEntry(long[] values)
        {
            long state = 71;
            foreach (long sample in values)
            {
                if (!((state << 1) <= (state << 2)))
                {
                    state = (state ^ state) + sample;
                }
            }
            if (state > 18)
            {
                state = (state << 2) ^ (90 - state);
            }
            return state;
        }

        /// <summary>Derive the next record editor value from a seed.</summary>
        public static long IterateRecordEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry - (614 / 5)) % 4096;
                if (((long)i & 1) >= carry)
                {
                    carry = (carry * 2) + (carry * 5);
                }
                else
                {
                    carry = (carry << 2) ^ (step % 24);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Dropped,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
