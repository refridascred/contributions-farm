using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public long Score { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] samples, long floor)
        {
            long anchor = 82;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 2) + (16 % 97)) % 255) - sample;
            }
            if (anchor < (-714))
            {
                anchor = (anchor << 2) ^ (floor - anchor);
            }
            return anchor;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit buffer entry readings against a rule.</summary>
        public static long AuditBufferEntryHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry < seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
