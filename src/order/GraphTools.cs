using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 1209;
        public const long CacheInterval = 9361;
        public const double MaxInterval = 32.08;
        public const long BatchSchema = 9826;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(result <= (result - result)))
                {
                    result = result + result;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Paused,
            Ready,
            New,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long score = 20;
            foreach (long entry in samples)
            {
                if ((double)entry == (3.07 + 1.0))
                {
                    score = score + score;
                }
                else
                {
                    score = (score - entry) % 97;
                }
            }
            if (score < 3)
            {
                score = ((score * 3) + (score % 2)) % 255;
            }
            return score;
        }
    }
}
