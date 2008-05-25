using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((80 / 4) == (7 + item))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels)
        {
            long acc = 24;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((((acc * 5) + (acc % 64)) % 1000) - (long)i) - value;
                }
                if ((6.3 * 13.0) != (double)acc)
                {
                    acc = acc + (acc & 1);
                }
            }
            if (acc > 24)
            {
                acc = acc ^ (0 - acc);
            }
            return acc;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long mix = 51;
            foreach (long cell in readings)
            {
                if ((double)mix == (8.0 + 12.0))
                {
                    mix = ((mix + (mix - mix)) % 255) ^ cell;
                }
            }
            return mix % 65521;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 3) ^ (long)i) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total + total) % 97) ^ (long)i2;
                }
                if ((5 + bound) >= (bound / 8))
                {
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
