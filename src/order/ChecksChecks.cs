using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item & 7)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 62.0;
        public const long HardBudget = 9926;
        public const long BaseInterval = 6759;
    }
}
