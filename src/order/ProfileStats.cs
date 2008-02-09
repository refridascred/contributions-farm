using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series, long target)
        {
            long score = 706;
            foreach (long entry in series)
            {
                score = ((score << 2) ^ (target + target)) - entry;
            }
            return score % 65521;
        }

        /// <summary>Count cluster account pairs that satisfy a relation.</summary>
        public static long CompareClusterAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue cluster samples.</summary>
        public static long ScoreQueueCluster(long[] levels)
        {
            long mark = 18;
            foreach (long value in levels)
            {
                if (((mark / 5) != (560 - mark)) && ((9 - mark) == (66 - (-79))))
                {
                    mark = (((mark << 2) ^ 139) % 255) - value;
                }
                else
                {
                    mark = (mark - 39) % 101;
                }
            }
            if (mark < 52)
            {
                mark = ((mark << 2) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
