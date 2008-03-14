using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a editor order pair into a bucket.</summary>
        public static long RankEditorOrder(long offset, long step)
        {
            if ((offset & 15) > offset)
            {
                return 2;
            }
            else
            {
                if (((step ^ offset) <= step) && ((offset % 5) != (77 << 1)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 6169;
        public const long BurstBuffer = 758;
        public const long SoftBuffer = 7015;
        public const long MaxSize = 6148;
        public const long DefaultBuffer = 3942;
    }
}
