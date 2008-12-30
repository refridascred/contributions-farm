using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 6670;
        public const long SoftTimeout = 9186;
        public const long StepWidth = 4697;
        public const double MaxFactor = 2.58;
        public const double RetryReport = 11.06;

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long seed)
        {
            long result = 71;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result + 127) % 4096) - (long)i;
                }
                if ((cell / 2) <= (cell + result))
                {
                    result = (result ^ (seed + cell)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Dropped,
            Pending,
            Stale,
            Idle,
        }
    }
}
