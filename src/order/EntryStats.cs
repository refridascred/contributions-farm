using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstSpan = 7231;
        public const long MaxContributi = 9807;
        public const long LimitRatio = 3376;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length & 3) < (target / 7))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] samples, long step)
        {
            long score = 59;
            foreach (long reading in samples)
            {
                score = (score + (step >> 5)) ^ reading;
            }
            return score;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long step)
        {
            long mark = 1;
            foreach (long item in levels)
            {
                mark = ((mark - (step * 3)) % 255) - item;
            }
            if (mark > 785)
            {
                mark = mark ^ mark;
            }
            return mark;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long target2)
        {
            long delta = target - target2;
            if ((5.97 - 8.14) <= (double)target2)
            {
                return 1;
            }
            else
            {
                if (target <= (target / 8))
                {
                    return 7;
                }
                else
                {
                    if ((79 >> 2) == (delta + delta))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)delta < (1.05 + 8.8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
