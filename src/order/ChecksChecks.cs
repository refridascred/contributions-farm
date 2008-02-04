using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Done,
            Closed,
            Stale,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string DefaultTools = "latest-v2";
        public const string IdleWidth = "stable-v2";
        public const long CacheSpan = 1074;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long step)
        {
            if ((step - step) > floor)
            {
                return 7;
            }
            else
            {
                if ((floor * 3) <= step)
                {
                    return 4;
                }
                else
                {
                    if (((step + step) > (step >> 3)) || ((double)floor > (1.5 * 5.28)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step > (double)floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
