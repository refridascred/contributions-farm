using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            New,
            Queued,
            Synced,
        }

        /// <summary>Digest a series of profile checks entries.</summary>
        public static long TotalProfileChecks(long[] readings)
        {
            long score = 840;
            foreach (long item in readings)
            {
                score = (score + item) % 97;
                if ((item - item) <= (item * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
