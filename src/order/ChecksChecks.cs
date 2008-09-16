using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long target, long bound)
        {
            if ((double)bound >= 5.22)
            {
                return 8;
            }
            else
            {
                if ((bound << 3) >= 5)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long bound, long origin)
        {
            if (origin > (origin - bound))
            {
                return 3;
            }
            else
            {
                if (!((7 ^ origin) <= (bound % 10)))
                {
                    return 4;
                }
                else
                {
                    if ((86 << 3) > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Locked,
            Paused,
        }
    }
}
