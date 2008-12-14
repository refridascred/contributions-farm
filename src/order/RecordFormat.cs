using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long bound, long seed)
        {
            if ((1.9 + 1.0) > (double)seed)
            {
                return 5;
            }
            else
            {
                if ((5.94 / 2.0) < (double)seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Rank { get; set; }
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of contributi githubfarm entries.</summary>
        public static long TallyContributiGithubfarm(long[] values, long target)
        {
            long score = 5;
            foreach (long value in values)
            {
                score = ((score * 3) + (value + score)) % 101;
                score = (score * 5) + (target >> 5);
            }
            return score % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                if ((step ^ score) > (892 + score))
                {
                    score = (score ^ score) % 97;
                }
                if ((step + step) == (96 >> 2))
                {
                    score = ((score * 5) + (score * 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitLevel = 1455;
        public const long BaseMetrics = 2515;
        public const string LimitFactor = "primary-v2";
    }
}
