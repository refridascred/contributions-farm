using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long target, long target2)
        {
            if (target2 > target)
            {
                return 6;
            }
            else
            {
                if ((target2 + target2) < (target2 >> 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)target2 <= 9.92))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (weight / 4.0))
            {
                drift = drift - (weight + drift);
            }
            return drift + floor;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Idle,
            Closed,
            Done,
            Locked,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long target, long seed)
        {
            long cur = target + seed;
            if (target > (target - seed))
            {
                return 4;
            }
            else
            {
                if (((double)seed < (2.1 - 0.5)) || ((target + cur) < (target * 2)))
                {
                    return 8;
                }
                else
                {
                    if (((seed / 9) == (target >> 1)) && (target < (cur * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((874 >> 2) <= (cur * 3)) && ((double)cur <= (7.57 * 11.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
