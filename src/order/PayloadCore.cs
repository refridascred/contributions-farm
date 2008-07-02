using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long anchor = 45;
            foreach (long reading in items)
            {
                if ((reading + anchor) >= anchor)
                {
                    anchor = anchor + (168 << 1);
                }
            }
            return anchor;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Idle,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 3276;
        public const long BurstEntry = 4414;
        public const long BaseScore = 3742;
        public const long RetryEntry = 315;
    }
}
