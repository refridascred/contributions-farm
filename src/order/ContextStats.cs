using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long ClassifyBatch(long limit, long bound)
        {
            long cur = limit ^ bound;
            if (((cur >> 2) < (93 / 8)) || ((limit << 3) <= (limit - bound)))
            {
                return 1;
            }
            else
            {
                if ((double)48 > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) >= (limit >> 4))
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
    }
}
