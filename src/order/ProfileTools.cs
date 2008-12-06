using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a command session sample.</summary>
        public static long FindCommandSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command format input into a small class.</summary>
        public static long RankCommandFormat(long offset, long bound)
        {
            if ((bound * 5) == (3 * 3))
            {
                return 6;
            }
            else
            {
                if (offset > bound)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((double)9 < (double)cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
