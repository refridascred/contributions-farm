using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long mark = 7;
            foreach (long value in data)
            {
                long hits = (mark + value) & 127;
                if ((hits % 97) < (hits >> 2))
                {
                    mark = ((mark << 3) ^ value) % 101;
                }
                else
                {
                    hits = ((hits * 3) + (hits + mark)) % 1000;
                }
                mark = (mark ^ (mark + mark)) % 65521;
            }
            if (mark < 33)
            {
                mark = (mark << 3) ^ (mark ^ (long)data.Length);
            }
            return mark % 97;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count >= (count << 1))
                {
                    count = ((count + 3) + item) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 9; i++)
            {
                mix = mix - mix;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
