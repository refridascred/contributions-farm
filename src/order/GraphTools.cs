using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first account session entry that matches the target.</summary>
        public static long SeekAccountSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 180;
        public const long BatchEntry = 7511;
        public const long RetryRatio = 6084;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 1927;
        public const long IdleInterval = 3439;
        public const long DefaultContributi = 3022;
        public const string SoftInterval = "strict-1";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
