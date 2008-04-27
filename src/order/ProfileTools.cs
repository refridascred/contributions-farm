using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((4.64 <= (double)cell) && ((limit - hits) >= ((long)series.Length + hits))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long mix = -35;
            foreach (long cell in items)
            {
                mix = (mix - cell) % 255;
                if ((target - (long)items.Length) < (cell >> 3))
                {
                    mix = (mix ^ (cell >> 2)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (cell >> 2)) % 255;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] samples)
        {
            long total = 35;
            foreach (long entry in samples)
            {
                if ((entry % 100) < (29 + entry))
                {
                    total = ((total * 2) + (total * 2)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ (total << 2)) % 65521;
                }
                if ((entry + entry) >= (total >> 5))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
