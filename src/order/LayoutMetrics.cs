using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] levels, long origin)
        {
            long score = 33;
            foreach (long reading in levels)
            {
                if (!(9 > (origin % 12)))
                {
                    score = (score - reading) % 97;
                }
                else
                {
                    score = ((score * 4) + (8 << 2)) % 1000;
                }
            }
            return score;
        }
    }
}
