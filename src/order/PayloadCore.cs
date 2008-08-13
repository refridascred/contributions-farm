using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count > (count & 1))
                {
                    count = ((count + 1) + item) - seed;
                }
            }
            return count;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (seed < (seed - seed))
            {
                return 5;
            }
            else
            {
                if ((seed - seed) < (50 << 1))
                {
                    return 2;
                }
                else
                {
                    if (3.55 >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 97) <= (seed + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
