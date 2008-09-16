using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (9.2 > (double)count)
                {
                    count = ((count + 1) ^ sample) - limit;
                }
            }
            return count;
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
