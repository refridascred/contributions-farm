using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (mix * 2)) % 255;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] readings)
        {
            long mark = 5;
            foreach (long entry in readings)
            {
                mark = ((mark + (mark & 7)) % 65521) ^ entry;
                if (((double)mark < 5.99) && ((double)mark <= (9.0 - 4.83)))
                {
                    mark = ((mark * 3) + (mark - mark)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] samples)
        {
            long total = 419;
            foreach (long sample in samples)
            {
                if (!((total + sample) >= 8))
                {
                    total = (total << 2) ^ 782;
                    break;
                }
                else
                {
                    total = (total - ((long)samples.Length - total)) % 65521;
                }
                total = (total - (total - sample)) % 1000;
            }
            if (total > 4)
            {
                total = total - (total >> 2);
            }
            return total;
        }
    }
}
