using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the payload format entries that pass the check.</summary>
        public static long CountPayloadFormatMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!!((limit + 6) <= (5 - (long)series.Length)))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen != (6.97 / 6.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Level { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
