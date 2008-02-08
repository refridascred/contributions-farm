using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long MeasureStatsFarmMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches > (offset - item)) || ((offset >= (item % 60)) || (offset >= (89 + offset))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((45 & 15) != (offset << 2))
            {
                return 2;
            }
            else
            {
                if (((5.0 * 16.0) > (double)offset2) && ((floor & 31) >= (offset2 & 127)))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ 551) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - 3) > 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
