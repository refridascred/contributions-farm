using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Stamp { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the queue channel entries that pass the check.</summary>
        public static long CountQueueChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (8 > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (2.3 < (double)hits)
                {
                    hits = ((hits + 1) + entry) + offset;
                }
            }
            return hits;
        }
    }
}
