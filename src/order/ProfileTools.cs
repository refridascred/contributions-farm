using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] series)
        {
            long score = 3;
            foreach (long datum in series)
            {
                score = (score + score) ^ datum;
            }
            if (score < 314)
            {
                score = ((score * 4) + (score - score)) % 4096;
            }
            return score;
        }

        /// <summary>Grade a metrics record value against two limits.</summary>
        public static long BucketMetricsRecord(long bound, long offset)
        {
            long diff = bound ^ offset;
            if (diff <= 124)
            {
                return 3;
            }
            else
            {
                if ((70 + bound) <= (68 + bound))
                {
                    return 4;
                }
                else
                {
                    if (((-7) + 772) < (offset - diff))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen >= (seen + seen)) && ((seen >> 3) >= (seen ^ 8))) && (((seen + 40) < (seen / 7)) && (seen >= (sample + sample))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long offset)
        {
            if ((bound ^ (-8)) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if ((849 & 3) > (offset % 24))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
