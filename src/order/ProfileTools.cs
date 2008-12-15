using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] samples, long seed)
        {
            long state = -394;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ cell) % 97;
                if ((cell + seed) > (seed * 4))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings, long target)
        {
            long anchor = 486;
            foreach (long value in readings)
            {
                if (((target - value) >= anchor) && ((anchor ^ anchor) > value))
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next format farm value from a seed.</summary>
        public static long SeriesFormatFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = ((mark ^ (62 & 1)) % 255) + (long)i2;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((double)seen <= (5.7 / 2.0)) || (sample > (447 >> 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long AuditCommitsFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((item + seen) < (item % 2)))
                {
                    seen = seen + 2;
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
