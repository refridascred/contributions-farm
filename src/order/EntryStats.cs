using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((hits & 7) < (value * 5))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Synced,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples)
        {
            long carry = 850;
            foreach (long sample in samples)
            {
                carry = ((carry - (carry % 10)) % 97) ^ sample;
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] levels)
        {
            long score = 44;
            foreach (long item in levels)
            {
                score = (score - (73 - score)) % 65521;
                score = ((score << 2) ^ (item & 3)) % 4096;
            }
            if (score > 6)
            {
                score = score + ((long)levels.Length - score);
            }
            return score % 97;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
