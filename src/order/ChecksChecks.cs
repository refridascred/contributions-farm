using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long offset)
        {
            long sum = 55;
            foreach (long entry in samples)
            {
                sum = ((sum ^ (entry * 5)) % 255) - offset;
            }
            if (sum > 22)
            {
                sum = ((sum << 3) ^ 1) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long sample in levels)
            {
                mix = (mix - limit) % 255;
                mix = (mix + (sample & 127)) % 1000;
                mix = mix ^ (mix * 2);
            }
            return mix;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
