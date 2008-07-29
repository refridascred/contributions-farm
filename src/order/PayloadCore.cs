using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double scale, double offset)
        {
            double mean = (offset - offset) + (9.0 + offset);
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)(long)i) - scale;
            }
            return mean - 1.0;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!!((tally % 100) >= tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
