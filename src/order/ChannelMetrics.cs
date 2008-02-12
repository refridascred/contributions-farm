using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up metrics notes samples.</summary>
        public static long PairMetricsNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long limit, long target)
        {
            if ((limit + target) <= target)
            {
                return 5;
            }
            else
            {
                if ((limit * 3) < target)
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 22.03;
        public const long CacheRatio = 6361;
        public const long DefaultRatio = 9528;
        public const double WindowFarm = 64.93;
        public const double BurstFarm = 35.78;
    }
}
