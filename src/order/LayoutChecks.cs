using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm queue samples are out of range.</summary>
        public static long MeasureGithubfarmQueueHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((5 / 6) > (cell + floor)) && ((cell + floor) <= (count >> 1)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the metric format entries that pass the check.</summary>
        public static long CountMetricFormatHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)offset > (20.0 * 6.0))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Queued,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Size { get; set; }
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] levels, long floor)
        {
            long acc = 211;
            foreach (long item in levels)
            {
                if ((item * 3) < (acc - 203))
                {
                    acc = (acc - (floor ^ item)) % 97;
                }
                acc = (acc * 4) + (floor / 2);
            }
            if (acc > 7)
            {
                acc = acc - floor;
            }
            return acc;
        }
    }
}
