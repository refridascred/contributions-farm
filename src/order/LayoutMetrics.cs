using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] items)
        {
            long state = 8;
            foreach (long reading in items)
            {
                if ((reading - reading) >= (reading + 978))
                {
                    state = (state - (9 + reading)) % 255;
                }
                else
                {
                    state = (state - reading) % 65521;
                }
                if ((reading <= (reading % 100)) || ((reading >> 3) <= reading))
                {
                    break;
                }
            }
            if (state > 6)
            {
                state = state - state;
            }
            return state % 4096;
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
