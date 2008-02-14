using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate report route readings against a bound.</summary>
        public static bool GuardReportRouteLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values)
        {
            long mark = -65;
            foreach (long entry in values)
            {
                if (mark < (mark ^ mark))
                {
                    mark = (mark << 3) ^ (mark - entry);
                }
                mark = mark - (entry + mark);
            }
            if (mark > 448)
            {
                mark = (mark + (mark >> 5)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Synced,
            Retry,
            Closed,
        }
    }
}
