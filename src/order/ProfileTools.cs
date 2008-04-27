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

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long value in samples)
            {
                if (acc < (value >> 3))
                {
                    acc = acc - value;
                }
                if ((7 > (acc + acc)) && ((double)acc >= (9.0 * 5.17)))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    break;
                }
                if ((6.0 >= (double)acc) || ((2.0 / 4.0) >= (double)limit))
                {
                    acc = (acc - (value / 8)) % 97;
                }
                else
                {
                    acc = (acc ^ (value + 769)) % 255;
                }
            }
            if (acc > 11)
            {
                acc = acc + (limit * 3);
            }
            return acc;
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
