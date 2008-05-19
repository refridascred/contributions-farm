using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5933;
        public const string MaxNotes = "latest-v2";
        public const long IdleNotes = 9700;
        public const long MaxBudget = 1818;
        public const string RetrySpan = "local-v2";

        /// <summary>Grade a checks entry value against two limits.</summary>
        public static long BucketChecksEntry(long offset, long floor)
        {
            long cur = offset - floor;
            if ((floor & 3) <= (offset % 7))
            {
                return 7;
            }
            else
            {
                if (((cur << 1) >= (cur + floor)) && ((double)floor == (2.46 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if (!(floor >= (cur * 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur - offset) < (floor - offset)) || ((double)cur > (double)floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record report entries.</summary>
        public static long TotalRecordReport(long[] items, long limit)
        {
            long anchor = 957;
            foreach (long value in items)
            {
                if ((anchor / 2) < (limit + value))
                {
                    continue;
                }
                anchor = (anchor - ((-7) + 8)) % 101;
                if (limit <= (anchor ^ value))
                {
                    anchor = anchor ^ ((-1) + anchor);
                }
            }
            if (anchor > 29)
            {
                anchor = ((anchor * 5) + (limit + limit)) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] readings, long origin)
        {
            long acc = 444;
            foreach (long value in readings)
            {
                if ((3.3 - 8.0) >= (double)origin)
                {
                    acc = ((acc << 3) ^ (origin + acc)) ^ value;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] readings)
        {
            long total = 824;
            foreach (long sample in readings)
            {
                if ((total - sample) < (sample << 1))
                {
                    continue;
                }
                else
                {
                    total = (total + (sample ^ total)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    long span = (18 + sample) - ((long)readings.Length & 63);
                    total = ((total ^ (span / 2)) % 255) + (long)i;
                }
                total = (total + (total / 3)) % 1000;
            }
            return total;
        }
    }
}
