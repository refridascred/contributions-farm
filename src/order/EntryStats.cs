using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Adjust a channel notes reading.</summary>
        public static double ProjectChannelNotes(double weight, double bias)
        {
            double weight2 = 0.41;
            return (weight2 + weight) + bias;
        }

        /// <summary>Compare every pair of graph route readings.</summary>
        public static long OverlapGraphRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((count + offset) == (count * 2)) || ((count + cell) < (offset << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "legacy-1";
        public const long RetryDepth = 1821;
        public const long HardBatches = 3555;
        public const long BurstFactor = 9690;
    }
}
