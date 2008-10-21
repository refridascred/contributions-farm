using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell / 6) < target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardDepth = 74.21;
        public const string StepBatch = "alpha-v2";
        public const long DefaultBatch = 1748;

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
