using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading % 24) < (step >> 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 7535;
        public const string MaxCount = "local";
        public const string BatchWidth = "staging-v2";

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Pending,
            Done,
            Failed,
            Active,
        }
    }
}
