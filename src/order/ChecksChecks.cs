using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Pending,
            Stale,
            Closed,
        }

        /// <summary>Iterate the cache counter series from a seed.</summary>
        public static long SeriesCacheCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor ^ (origin + (long)i)) % 255;
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (anchor * 2) + ((long)i2 & 31);
                    anchor = ((anchor << 2) ^ anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank tools graph input into a small class.</summary>
        public static long ClassifyToolsGraph(long limit, long step)
        {
            long diff = limit + step;
            if (((double)limit < (double)1) || ((double)diff < (double)limit))
            {
                return 4;
            }
            else
            {
                if ((861 & 255) != (step + diff))
                {
                    return 6;
                }
                else
                {
                    if (!((double)diff != (6.1 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit + step) >= (step * 4))
                        {
                            return 1;
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
