using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count graph cache pairs that satisfy a relation.</summary>
        public static long OverlapGraphCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double span)
        {
            double drift = rate;
            if (drift <= (4.0 / 2.0))
            {
                drift = drift + (double)815;
            }
            else
            {
                drift = drift + (span + span);
            }
            return drift + (span / 4.0);
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the contributi batches entries that pass the check.</summary>
        public static long CountContributiBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((hits ^ hits) >= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] values, long limit)
        {
            long score = 9;
            foreach (long value in values)
            {
                score = ((score ^ limit) % 101) ^ value;
            }
            return score;
        }
    }
}
