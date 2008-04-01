using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state >= (double)4)
                {
                    state = (state + (8 >> 1)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
