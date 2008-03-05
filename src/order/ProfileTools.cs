using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up already stats samples.</summary>
        public static long PairAlreadyStatsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
                if ((score * 2) <= target)
                {
                    score = (score - (target ^ target)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] samples, long target)
        {
            long score = 3;
            foreach (long cell in samples)
            {
                score = (((score * 4) + (score * 3)) % 4096) ^ cell;
            }
            if (score < 7)
            {
                score = ((score * 2) + (target + target)) % 65521;
            }
            return score;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long acc = 52;
            foreach (long item in items)
            {
                if (acc > (item + 339))
                {
                    acc = ((acc - (item % 16)) % 1000) - limit;
                }
                else
                {
                    acc = (acc << 2) ^ (item - item);
                }
            }
            if (acc > 66)
            {
                acc = acc + acc;
            }
            return acc;
        }
    }
}
