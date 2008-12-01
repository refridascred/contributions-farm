using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile cache samples.</summary>
        public static long FoldProfileCache(long[] levels)
        {
            long mark = 3;
            foreach (long value in levels)
            {
                if (value > ((long)levels.Length + value))
                {
                    mark = (mark - (mark - value)) % 1000;
                }
            }
            if (mark > 33)
            {
                mark = (mark + (mark / 3)) % 4096;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstWidth = 5142;
        public const double HardFactor = 78.18;
        public const long SoftBuffer = 5392;
        public const string BurstBuffer = "cached-1";

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
