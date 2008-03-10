using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 6432;
        public const long RetryCommits = 7920;
        public const string MaxCommits = "staging";
        public const long SoftCommits = 7872;
        public const double StepLevel = 92.8;

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleLevel = 42.11;
        public const string BatchLevel = "staging-1";
        public const long BatchFactor = 186;
        public const long LimitCount = 7498;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
