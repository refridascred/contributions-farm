using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count report token pairs that satisfy a relation.</summary>
        public static long MatchReportTokenCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mix = 437;
            foreach (long reading in items)
            {
                mix = (mix - offset) - reading;
            }
            if (mix < 8)
            {
                mix = (mix + (offset & 15)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long score = -4;
            foreach (long value in data)
            {
                score = score - (score * 5);
                score = (score - score) % 1000;
                score = (score * 5) + value;
            }
            return score;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
