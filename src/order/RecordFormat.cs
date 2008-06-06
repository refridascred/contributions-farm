using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long offset, long floor)
        {
            if ((5 >> 1) <= offset)
            {
                return 1;
            }
            else
            {
                if ((offset ^ floor) < (offset ^ 9))
                {
                    return 8;
                }
                else
                {
                    if (((69 + offset) == (floor - offset)) && ((offset + offset) >= (offset + floor)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowSize = 5564;
        public const long MinFactor = 5164;
        public const long MinDepth = 423;

        /// <summary>Look up the position of a stats farm sample.</summary>
        public static long FindStatsFarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
