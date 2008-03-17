using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] series, long origin)
        {
            long score = -85;
            foreach (long sample in series)
            {
                if ((sample + score) >= sample)
                {
                    score = score + origin;
                }
                if (!((origin * 5) != (3 & 7)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long step)
        {
            long acc = 55;
            foreach (long value in series)
            {
                acc = ((acc + (value + acc)) % 4096) - step;
                acc = (acc + acc) % 65521;
                if (!((acc * 2) >= (value + acc)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit cache record readings against a rule.</summary>
        public static long AuditCacheRecordMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample < (double)step) || ((step + hits) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 286;
            foreach (long item in levels)
            {
                if ((score + item) < (96 - score))
                {
                    score = (score + item) % 1000;
                }
                else
                {
                    score = (score + (item - score)) % 97;
                }
            }
            if (score < 373)
            {
                score = (score - (score + score)) % 65521;
            }
            return score;
        }
    }
}
