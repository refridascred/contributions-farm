using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    result = ((result + (limit + result)) % 97) - (long)i2;
                }
                long next = (long)i;
                if (!((long)i < next))
                {
                    next = next - ((long)i >> 3);
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 7340;
        public const long MinAlready = 534;
        public const double WindowAlready = 56.38;

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] items)
        {
            long state = -6;
            foreach (long item in items)
            {
                long gap = 72;
                if ((state & 255) > (gap * 4))
                {
                    state = ((state << 3) ^ item) % 101;
                }
                else
                {
                    gap = ((gap * 3) + (item % 100)) % 4096;
                }
                if ((item >> 4) > (0 << 1))
                {
                    state = (state - (636 / 7)) % 1000;
                }
            }
            if (state > 1)
            {
                state = (state * 2) + (state + state);
            }
            return state;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
