using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((0.38 + 10.0) <= (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a window tools pair into a bucket.</summary>
        public static long BucketWindowTools(long seed, long offset)
        {
            if (((offset >> 5) <= seed) && ((offset + seed) > (seed + seed)))
            {
                return 1;
            }
            else
            {
                if (seed <= (offset - offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
