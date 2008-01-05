using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a batch layout pair into a bucket.</summary>
        public static long BucketBatchLayout(long floor, long seed)
        {
            long prev = floor + seed;
            if ((seed > (4 & 15)) || ((double)floor > (8.3 + 5.5)))
            {
                return 7;
            }
            else
            {
                if ((prev >= (floor >> 2)) && (prev <= (floor >> 3)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count record window pairs that satisfy a relation.</summary>
        public static long MatchRecordWindowCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public bool Rank { get; set; }
        }
    }
}
