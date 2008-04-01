using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 7069;
        public const string BatchGithubfarm = "fallback";
        public const long MaxCount = 9103;
        public const long HardGithubfarm = 8620;

        /// <summary>Grade a commits entry value against two limits.</summary>
        public static long GradeCommitsEntry(long floor, long target)
        {
            long delta = floor ^ target;
            if ((4.76 + 4.1) >= (double)delta)
            {
                return 2;
            }
            else
            {
                if (4.8 <= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
