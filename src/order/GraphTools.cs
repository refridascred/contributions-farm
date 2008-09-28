using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long target, long step)
        {
            long lane = target - step;
            if ((step & 31) > (step % 5))
            {
                return 3;
            }
            else
            {
                if ((3.6 - 0.4) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((target + lane) == (step + step))
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

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Level { get; set; } = "";
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Ready,
            Idle,
            Closed,
            Queued,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] samples)
        {
            long carry = 876;
            foreach (long datum in samples)
            {
                carry = ((carry - carry) % 1000) ^ datum;
            }
            return carry % 65521;
        }

        /// <summary>Iterate the token format series from a seed.</summary>
        public static long SeriesTokenFormat(long floor)
        {
            long score = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((score - score) < (27 ^ score))
                {
                    score = score + score;
                    score = score + score;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
