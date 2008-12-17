using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5705;
        public const string HardBudget = "primary";
        public const double BaseFarm = 14.09;
        public const string DefaultFarm = "staging-edge";
        public const double StepFarm = 43.38;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstInterval = 5279;
        public const long BatchContributi = 6492;
        public const long MinTimeout = 6817;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Active,
            Paused,
        }

        /// <summary>Check that every schema farm entry stays within the limit.</summary>
        public static bool GuardSchemaFarmLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
