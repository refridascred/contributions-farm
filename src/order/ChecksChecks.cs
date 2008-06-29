using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a profile metrics reading by value.</summary>
        public static long FindProfileMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BaseSchema = "open-edge";
        public const long CacheWidth = 9508;
        public const long CacheSchema = 1038;
        public const string StepScore = "stable-v2";
        public const long MaxCount = 1633;

        /// <summary>Locate a editor tools reading by value.</summary>
        public static long SeekEditorToolsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
