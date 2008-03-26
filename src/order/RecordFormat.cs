using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long target)
        {
            long total = 56;
            foreach (long value in series)
            {
                total = ((total + (target + total)) % 4096) + value;
            }
            if (total < 2)
            {
                total = (total - (total + target)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long origin)
        {
            long offset2 = offset + origin;
            if ((8.0 * 7.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if (origin > 328)
                {
                    return 3;
                }
                else
                {
                    if ((99 >> 5) == (offset2 & 31))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6.5 >= (double)offset2)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor + ((long)i & 255);
                if (((200 ^ anchor) == (limit >> 1)) || ((double)limit < (11.0 + 2.9)))
                {
                    anchor = anchor ^ limit;
                }
                anchor = (anchor * 3) + limit;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long offset, long offset2)
        {
            if (((double)offset2 >= (7.3 * 7.9)) || ((5.0 - 5.0) == (double)offset2))
            {
                return 1;
            }
            else
            {
                if ((6 + offset) >= (offset2 + offset))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
