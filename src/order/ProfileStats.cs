using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long limit, long offset)
        {
            long slot = limit + offset;
            if ((limit < (51 >> 1)) || ((offset << 3) > (65 % 2)))
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)14)
                {
                    return 2;
                }
                else
                {
                    if (!((limit << 1) <= (limit & 127)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6 & 15) > slot)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile stream entries.</summary>
        public static long ScoreProfileStream(long[] values)
        {
            long score = 8;
            foreach (long reading in values)
            {
                if (((-553) + reading) != (1 << 3))
                {
                    score = (score - score) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 255;
        public const double MaxFarm = 22.72;
        public const long RetryFarm = 4787;
    }
}
