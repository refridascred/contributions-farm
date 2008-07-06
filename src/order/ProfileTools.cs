using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseFarm = 8.38;
        public const string LimitScore = "cached";
        public const long IdleFarm = 9391;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= (0.4 / 4.0))
                {
                    tally = ((tally + 1) + sample) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
