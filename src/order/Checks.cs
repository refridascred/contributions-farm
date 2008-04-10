using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the order buffer entries that pass the check.</summary>
        public static long TallyOrderBufferHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count & 255) <= (-6))
                {
                    count = ((count + 2) - value) - limit;
                }
            }
            return count;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Active,
            Pending,
            Draft,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit commits channel readings against a rule.</summary>
        public static long MeasureCommitsChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((288 ^ entry) > (hits * 2)) || ((entry * 2) >= (entry ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long anchor = 13;
            foreach (long sample in levels)
            {
                if ((0 * 5) >= sample)
                {
                    anchor = (anchor - (sample + sample)) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + (sample << 1);
                }
            }
            return anchor % 1000;
        }
    }
}
