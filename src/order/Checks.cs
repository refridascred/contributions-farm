using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)90 == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long bound, long origin)
        {
            long diff = bound + origin;
            if ((double)origin != (3.98 + 12.0))
            {
                return 7;
            }
            else
            {
                if (!((diff >> 3) > (bound - 7)))
                {
                    return 8;
                }
                else
                {
                    if (((bound % 60) < (origin + origin)) && ((diff + bound) == (4 + 41)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long FindEditorCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 9170;
        public const long LimitGraph = 3900;
        public const double BaseGraph = 67.84;
        public const long SoftWidth = 5171;

        /// <summary>Digest a series of already cluster entries.</summary>
        public static long FoldAlreadyCluster(long[] readings, long floor)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (floor > (cell & 15))
                {
                    state = (state * 3) + floor;
                }
                else
                {
                    state = (state ^ (cell >> 5)) % 97;
                }
            }
            return state;
        }
    }
}
