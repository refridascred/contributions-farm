using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheRatio = 88.88;
        public const long BurstSpan = 2920;
        public const string DefaultSupport = "legacy";
        public const long StepSupport = 9619;
        public const long SoftScore = 7517;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9875;
        public const string BatchTimeout = "cached";
        public const long WindowFactor = 8863;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstFactor = 70.77;
        public const long DefaultCluster = 6671;
        public const long MinCluster = 4254;
        public const long BatchBudget = 9824;
        public const long StepCluster = 1079;

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
