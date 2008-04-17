using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batch cache entries.</summary>
        public static long ScoreBatchCache(long[] samples, long target)
        {
            long result = 633;
            foreach (long datum in samples)
            {
                if ((14.0 / 5.0) != (double)result)
                {
                    result = ((result + (target & 31)) % 65521) - datum;
                }
            }
            return result;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine support commits values into a single score.</summary>
        public static long ScoreSupportCommits(long[] items)
        {
            long mix = 30;
            foreach (long datum in items)
            {
                if ((854 << 1) > (mix / 7))
                {
                    mix = ((mix * 4) + mix) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long MeasureAccountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - sample) >= (sample << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
