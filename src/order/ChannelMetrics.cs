using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long target)
        {
            long cur = step ^ target;
            if ((8.8 * 2.3) < (double)cur)
            {
                return 3;
            }
            else
            {
                if ((757 + 13) < (target - 64))
                {
                    return 0;
                }
                else
                {
                    if ((step % 12) <= (step + cur))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((8 ^ step) < (target % 100)) || ((double)cur < 8.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
