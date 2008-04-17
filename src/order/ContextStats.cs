using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster window entries.</summary>
        public static long ScoreClusterWindow(long[] samples)
        {
            long total = 100;
            foreach (long cell in samples)
            {
                if ((double)cell > (0.4 * 9.29))
                {
                    total = (total - (89 * 2)) % 4096;
                }
            }
            if (total > 5)
            {
                total = ((total * 3) + total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long origin)
        {
            if ((801 ^ floor) > (origin + floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) > (60 & 127))
                {
                    return 2;
                }
                else
                {
                    if (!((floor & 7) <= floor))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((12 - origin) == (floor ^ origin)) && (floor > (floor + floor)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route payload readings against a bound.</summary>
        public static bool CheckRoutePayloadRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up tools notes samples.</summary>
        public static long MatchToolsNotesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
