using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Closed,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long offset, long offset2)
        {
            if (((offset2 - 98) >= (offset & 31)) && ((8 - offset2) > offset))
            {
                return 5;
            }
            else
            {
                if ((offset2 + 5) >= offset)
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 + offset2) <= ((-4) ^ offset2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((18.0 - 3.56) > (double)offset) && ((offset2 - offset2) > (offset2 / 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank notes checks input into a small class.</summary>
        public static long GradeNotesChecks(long limit, long origin)
        {
            long prev = limit + origin;
            if ((prev + limit) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)limit <= 5.0)
                {
                    return 6;
                }
                else
                {
                    if (!((prev ^ origin) != (origin ^ prev)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev >> 3) <= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
