using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value ^ 223) <= (308 + value))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Roll a account layout counter forward.</summary>
        public static long RollAccountLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor << 3) ^ 3;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultDepth = 1722;
        public const long LimitSpan = 9087;
        public const double RetryGithubfarm = 72.07;
        public const string BurstTimeout = "strict-v2";
        public const long MaxGithubfarm = 9991;
    }
}
