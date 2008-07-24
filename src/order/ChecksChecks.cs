using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3215;
        public const long LimitSize = 9812;
        public const long MaxProfile = 64;

        /// <summary>Locate a graph githubfarm reading by value.</summary>
        public static long SeekGraphGithubfarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
