using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data, long floor)
        {
            long result = 19;
            foreach (long value in data)
            {
                if ((value - floor) <= result)
                {
                    result = result + (result - 597);
                }
                else
                {
                    result = result + (result ^ result);
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 2228;
        public const string DefaultRatio = "fallback-v2";
        public const long DefaultLevel = 7768;
        public const long StepSize = 1026;
        public const long StepSchema = 3537;
    }
}
