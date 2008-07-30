using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit notes queue readings against a rule.</summary>
        public static long MeasureNotesQueueOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)0 > (double)reading)
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stats queue values into a single score.</summary>
        public static long DigestStatsQueue(long[] series, long limit)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                if (((acc + acc) < cell) || ((cell & 255) <= acc))
                {
                    acc = ((acc * 2) + (limit / 5)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] levels, long origin)
        {
            long total = 59;
            foreach (long sample in levels)
            {
                total = ((total * 4) + (origin * 5)) % 255;
                if ((origin % 16) < (403 % 7))
                {
                    total = (total - (sample >> 1)) % 97;
                }
                else
                {
                    total = ((total << 3) ^ (origin + total)) % 255;
                }
                total = total ^ origin;
                if (total > (10 * 3))
                {
                    break;
                }
            }
            if (total > 3)
            {
                total = total - (origin - total);
            }
            return total;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Active,
            Stale,
            Draft,
            Paused,
        }
    }
}
