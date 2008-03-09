using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels)
        {
            long anchor = -83;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (-7)) % 4096) + datum;
                anchor = (anchor - ((-937) / 8)) % 65521;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Audit commits account readings against a rule.</summary>
        public static long CountCommitsAccountHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((626 - 6) <= (target - 73))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long origin)
        {
            long mark = 422;
            foreach (long cell in readings)
            {
                if ((origin + cell) == (7 + origin))
                {
                    mark = ((mark << 3) ^ (origin * 2)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
