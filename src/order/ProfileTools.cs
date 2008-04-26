using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account tools readings against a bound.</summary>
        public static bool ValidateAccountToolsRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Failed,
            Done,
            New,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Retry,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series)
        {
            long acc = 285;
            foreach (long reading in series)
            {
                acc = (acc ^ (345 ^ reading)) % 1000;
                if ((reading + 78) != (acc / 4))
                {
                    acc = acc ^ (reading % 16);
                }
                if ((acc ^ acc) > ((long)series.Length << 2))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 5557;
        public const double BurstTools = 54.05;
        public const long MinDepth = 1426;
    }
}
