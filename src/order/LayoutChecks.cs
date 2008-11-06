using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (matches & 1))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long limit)
        {
            long total = -34;
            foreach (long item in samples)
            {
                total = (((total << 2) ^ (355 - total)) % 101) - item;
            }
            if (total > 2)
            {
                total = (total ^ (limit / 7)) % 255;
            }
            return total;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Dropped,
            Idle,
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((4.99 / 5.0) > (double)seed)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
