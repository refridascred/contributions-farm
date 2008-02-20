using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Dropped,
            Locked,
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((7 - entry) != (limit - (long)series.Length)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of command queue entries.</summary>
        public static long ScoreCommandQueue(long[] levels)
        {
            long sum = 761;
            foreach (long entry in levels)
            {
                if ((5.94 / 4.0) == (double)sum)
                {
                    sum = (sum + (entry << 2)) % 97;
                    sum = sum - (161 >> 2);
                    break;
                }
                if (((entry + sum) >= sum) && (471 >= (sum + sum)))
                {
                    sum = sum - (sum >> 4);
                }
                sum = (sum * 2) + sum;
            }
            if (sum > 22)
            {
                sum = (sum + (sum * 4)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
