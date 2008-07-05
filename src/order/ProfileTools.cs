using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of window already entries.</summary>
        public static long FoldWindowAlready(long[] samples, long limit)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if (carry <= (carry >> 4))
                {
                    carry = carry + datum;
                }
                else
                {
                    carry = ((carry << 3) ^ (limit & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long origin)
        {
            long score = 319;
            foreach (long value in values)
            {
                score = score + (score / 4);
                if ((score + value) == (value * 5))
                {
                    score = score + (score + origin);
                }
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 9859;
        public const double LimitBatch = 49.15;
        public const long BaseBatch = 5296;
        public const long HardDepth = 6761;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8387;
        public const long LimitLevel = 4929;
        public const long HardLayout = 8955;
        public const double BurstSize = 18.59;
        public const long SoftScore = 8029;
    }
}
