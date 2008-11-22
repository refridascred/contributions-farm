using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Queued,
            Ready,
        }

        /// <summary>Validate editor checks readings against a bound.</summary>
        public static bool CheckEditorChecksLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
