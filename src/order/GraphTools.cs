using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((2 * 3) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double scale, double bias)
        {
            double bias2 = (scale / 7.0) - (bias * 13.0);
            if (bias2 < bias2)
            {
                bias2 = bias2 - 7.5;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (scale / 9.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] data, long limit)
        {
            long anchor = 52;
            foreach (long cell in data)
            {
                anchor = ((anchor - cell) % 65521) + limit;
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long target, long seed)
        {
            long prev = target - seed;
            if (!((target - target) >= (-788)))
            {
                return 8;
            }
            else
            {
                if ((seed >> 2) < (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if (((prev % 64) <= (3 << 2)) && ((target << 2) == (5 % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((9 - 148) >= (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
