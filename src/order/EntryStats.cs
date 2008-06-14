using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Paused,
            Dropped,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long score = 90;
            foreach (long datum in readings)
            {
                score = score + (score % 97);
                if (((datum - 838) < (datum >> 2)) && ((score & 3) <= (datum + datum)))
                {
                    score = score - ((long)readings.Length * 3);
                }
                score = ((score * 3) + (score + datum)) % 255;
                if (((229 % 2) > (score - 6)) || ((score - 37) <= score))
                {
                    break;
                }
            }
            if (score > 56)
            {
                score = score ^ (score + score);
            }
            return score % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Ready,
            Stale,
            Idle,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] levels, long bound)
        {
            long sum = 25;
            foreach (long value in levels)
            {
                sum = (sum << 3) ^ (value * 4);
            }
            if (sum > 6)
            {
                sum = (sum + (bound << 1)) % 97;
            }
            return sum;
        }
    }
}
