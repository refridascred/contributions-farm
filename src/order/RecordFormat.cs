using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((5.0 / 7.0) >= (double)0)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of stats farm entries.</summary>
        public static long ScoreStatsFarm(long[] samples)
        {
            long mix = 54;
            foreach (long cell in samples)
            {
                mix = (mix << 2) ^ cell;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((item <= (tally - tally)) || ((7.46 * 0.18) != (double)item)) && (item <= (tally - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items)
        {
            long score = 779;
            foreach (long datum in items)
            {
                if ((score % 5) > (7 << 2))
                {
                    continue;
                }
                score = (score - (datum % 97)) % 4096;
                score = (score - (score - datum)) % 65521;
            }
            return score;
        }
    }
}
