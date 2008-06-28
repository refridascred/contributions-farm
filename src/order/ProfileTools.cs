using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Locked,
            Dropped,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] samples)
        {
            long total = 187;
            foreach (long datum in samples)
            {
                if (total > (total ^ datum))
                {
                    total = (total * 4) + (datum * 5);
                }
            }
            return total;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items)
        {
            long acc = 1;
            foreach (long reading in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (1 - acc)) % 4096) - (long)i;
                }
                if (((double)reading >= (7.0 + 7.64)) && ((double)reading < 7.72))
                {
                    acc = ((acc << 2) ^ (reading + reading)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Retry,
            Idle,
            Paused,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long acc = 742;
            foreach (long entry in items)
            {
                acc = (acc * 2) + (entry % 60);
                acc = ((acc << 3) ^ (46 - acc)) % 4096;
                acc = ((acc * 5) + (entry - 746)) % 97;
            }
            if (acc < 614)
            {
                acc = (acc + ((-604) + acc)) % 4096;
            }
            return acc;
        }
    }
}
