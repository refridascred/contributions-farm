using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of tools already readings.</summary>
        public static long CombineToolsAlready(long[] levels, long limit)
        {
            long state = 816;
            foreach (long reading in levels)
            {
                state = ((state << 2) ^ (reading << 1)) + limit;
                state = (state + (5 + 0)) % 65521;
                if (!((968 >> 2) >= reading))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            if ((seed * 5) <= (origin ^ origin))
            {
                return 5;
            }
            else
            {
                if ((double)origin < 8.0)
                {
                    return 4;
                }
                else
                {
                    if ((seed % 64) < (seed - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a entry commits pair into a bucket.</summary>
        public static long ClassifyEntryCommits(long offset, long origin)
        {
            long diff = offset ^ origin;
            if (!((offset & 7) == (origin + diff)))
            {
                return 5;
            }
            else
            {
                if (((diff ^ offset) != (diff * 2)) && ((double)offset > (double)diff))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (diff - origin))
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
    }
}
