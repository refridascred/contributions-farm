using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitSize = 8831;
        public const long LimitInterval = 9415;
        public const double BaseCache = 82.63;

        /// <summary>Roll a entry notes counter forward.</summary>
        public static long StepEntryNotes(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if (!(target < ((long)i ^ target)))
                {
                    anchor = ((anchor * 4) + ((long)i << 1)) % 97;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
