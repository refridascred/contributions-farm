using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 3233;
        public const long DefaultStats = 925;
        public const long WindowRatio = 2125;
        public const long HardTimeout = 8033;

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitDepth = 9660;
        public const long MaxDepth = 6914;
        public const long StepEntry = 4539;
    }
}
