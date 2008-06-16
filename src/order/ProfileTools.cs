using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the record order entries that pass the check.</summary>
        public static long CountRecordOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((double)value >= (7.0 / 3.0)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            New,
            Pending,
            Ready,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] values, long step)
        {
            long score = 5;
            foreach (long datum in values)
            {
                if ((double)score <= (double)step)
                {
                    score = (score + (datum - score)) % 65521;
                }
                else
                {
                    score = score - (score % 3);
                }
                score = (score ^ (-941)) % 1000;
            }
            if (score > 453)
            {
                score = (score - (step ^ 427)) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
