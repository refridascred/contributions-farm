using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long AuditBatchesPayloadMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally & 3) <= (68 + datum))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >> 1) == (entry >> 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample != (7.0 + 6.5))
                {
                    count = (count + 1) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 17; i++)
            {
                mix = mix ^ (long)i;
                mix = mix + (mix - offset);
                mix = mix - (offset * 3);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
