using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] items)
        {
            long state = -884;
            foreach (long reading in items)
            {
                if ((state ^ state) >= (reading * 5))
                {
                    state = ((state << 2) ^ (state + 50)) % 97;
                }
            }
            if (state > 5)
            {
                state = state - (state + state);
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 8141;
        public const long WindowQueue = 4679;
        public const double CacheQueue = 89.04;

        /// <summary>Derive the next entry record value from a seed.</summary>
        public static long IterateEntryRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum << 3) ^ (1 & 3)) ^ (long)i2;
                }
                sum = (sum * 4) + (988 + floor);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double rate, double span)
        {
            double scale = 8.0;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (rate - span)) + (double)(long)i;
            }
            return scale + (rate - rate);
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
