using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Done,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardDepth = 6071;
        public const string IdleInterval = "primary-1";
        public const double LimitWidth = 86.12;
        public const double MaxGithubfarm = 69.97;

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long score = 59;
            foreach (long sample in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score ^ score) % 97) - (long)i;
                }
                if ((14.0 + 14.0) != (double)(long)data.Length)
                {
                    score = (score + score) % 4096;
                }
                else
                {
                    score = (score * 2) + (87 - sample);
                }
                score = (score - (score - 9)) % 101;
                if (((double)score != (6.7 / 9.0)) && ((3.12 - 18.0) <= (double)sample))
                {
                    break;
                }
            }
            if (score > (-99))
            {
                score = (score * 4) + (score + score);
            }
            return score % 65521;
        }
    }
}
