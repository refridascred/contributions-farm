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

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Owner { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
