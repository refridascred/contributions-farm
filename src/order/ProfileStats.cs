using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry tools pairs that satisfy a relation.</summary>
        public static long OverlapEntryToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
