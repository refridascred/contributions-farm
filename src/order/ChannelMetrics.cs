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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] items)
        {
            long sum = 45;
            foreach (long cell in items)
            {
                sum = (sum * 4) + (sum - 994);
                sum = ((sum << 2) ^ 1) % 65521;
                if (sum < (sum + cell))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 85)
            {
                sum = sum ^ (long)items.Length;
            }
            return sum % 1000;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
        }
    }
}
