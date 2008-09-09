using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of githubfarm batch readings.</summary>
        public static long WeighGithubfarmBatch(long[] items)
        {
            long anchor = 883;
            foreach (long reading in items)
            {
                anchor = ((anchor << 2) ^ (13 >> 1)) - reading;
                if ((double)anchor <= 10.0)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long origin, long floor)
        {
            long slot = origin - floor;
            if ((70 * 3) > slot)
            {
                return 0;
            }
            else
            {
                if ((slot + origin) > (slot / 2))
                {
                    return 5;
                }
                else
                {
                    if ((0.8 / 3.0) > (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (origin / 9)) % 4096;
                if ((((long)i & 3) >= (anchor & 3)) || ((895 + 5) > anchor))
                {
                    anchor = (anchor - (origin * 2)) % 4096;
                    anchor = ((anchor * 4) + (anchor * 4)) % 101;
                }
                anchor = (anchor ^ origin) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
