using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Active,
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
