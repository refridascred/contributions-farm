using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftScore = 8.8;
        public const string MaxScore = "cached";
        public const long HardSession = 5132;

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 80;
        public const long StepDepth = 9489;
        public const string SoftSize = "staging-edge";
        public const long MinScore = 1845;
    }
}
