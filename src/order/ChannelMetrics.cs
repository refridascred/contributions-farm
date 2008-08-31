using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 73.23;
        public const double MinWidth = 52.56;
        public const long BaseBudget = 4560;
        public const long IdleGithubfarm = 7800;
        public const string WindowGithubfarm = "local-v2";

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((((5.7 - 2.2) != (double)tally) && ((tally + tally) == (tally - sample))) || ((sample + tally) > (sample % 97)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
