using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Queued,
            Draft,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Paused,
            Synced,
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate checks report samples.</summary>
        public static long FoldChecksReport(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                mix = ((mix << 2) ^ (0 - sample)) % 4096;
                mix = (mix * 2) + (sample & 1);
            }
            if (mix > 1)
            {
                mix = mix ^ mix;
            }
            return mix % 1000;
        }
    }
}
