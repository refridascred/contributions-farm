using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long target)
        {
            long span = floor + target;
            if (6 >= floor)
            {
                return 4;
            }
            else
            {
                if ((target >> 2) < 7)
                {
                    return 2;
                }
                else
                {
                    if (!((span * 5) >= (floor * 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor >= (floor + 9))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long floor)
        {
            long score = 1;
            foreach (long value in items)
            {
                if ((score * 2) <= (score - value))
                {
                    score = ((score << 3) ^ value) % 65521;
                }
            }
            if (score > 4)
            {
                score = score + (floor << 2);
            }
            return score;
        }
    }
}
