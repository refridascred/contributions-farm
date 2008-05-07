using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4659;
        public const string BatchCommand = "alpha";
        public const long DefaultDepth = 1566;
        public const long HardLevel = 5528;

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally - datum) <= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
