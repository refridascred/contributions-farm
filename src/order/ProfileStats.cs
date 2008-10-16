using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long bound, long offset)
        {
            if ((899 << 3) == (477 - offset))
            {
                return 6;
            }
            else
            {
                if ((bound + offset) == (offset / 9))
                {
                    return 7;
                }
                else
                {
                    if ((1.6 - 5.1) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 50.44;
        public const long RetryScore = 3805;
        public const double SoftSupport = 51.97;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (642 & 255);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit window context readings against a rule.</summary>
        public static long TallyWindowContextOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry & 7) >= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
