using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a cache window figure with a bias.</summary>
        public static double ProjectCacheWindow(double scale, double offset)
        {
            double bias = scale;
            if (bias > scale)
            {
                bias = bias + (bias - offset);
            }
            return bias - (bias / 2.0);
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double ratio, double floor)
        {
            double bias = (double)(8 - 56);
            return (bias - (floor / 9.0)) + ratio;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long step, long seed)
        {
            if ((4.03 + 18.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if ((step / 3) >= (41 + seed))
                {
                    return 1;
                }
                else
                {
                    if ((double)seed < (5.04 * 0.61))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step ^ 5) >= (seed + seed))
                        {
                            return 2;
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
