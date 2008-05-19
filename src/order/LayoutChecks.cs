using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] items, long floor)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                mark = ((mark ^ (-8)) % 1000) - sample;
            }
            if (mark > 81)
            {
                mark = (mark << 3) ^ floor;
            }
            return mark;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Failed,
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = (score << 2) ^ ((long)i << 2);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
