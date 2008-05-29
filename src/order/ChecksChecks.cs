using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long HardCount = 7042;
        public const double MinFactor = 96.21;
        public const long StepSize = 3266;
        public const long BatchRecord = 2813;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxLayout = "staging";
        public const double SoftRatio = 21.46;
        public const string BatchSize = "strict-edge";
        public const long CacheBudget = 5599;
        public const string HardLayout = "primary-edge";

        /// <summary>Fold a list of notes graph readings.</summary>
        public static long CombineNotesGraph(long[] items, long target)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((13.0 * 16.0) == (double)target)
                {
                    score = ((score << 3) ^ ((-649) << 1)) ^ item;
                }
                else
                {
                    score = ((score << 3) ^ (score / 8)) % 4096;
                }
                if ((target >> 1) <= target)
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
