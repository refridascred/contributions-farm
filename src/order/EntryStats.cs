using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit buffer githubfarm readings against a rule.</summary>
        public static long TallyBufferGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen % 97) < (seen + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Active,
            Dropped,
            Done,
            Closed,
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + offset) > (993 + offset))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series)
        {
            long state = 45;
            foreach (long datum in series)
            {
                if (state >= (datum / 5))
                {
                    state = (state ^ (state - datum)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = ((total - (-91)) % 101) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
