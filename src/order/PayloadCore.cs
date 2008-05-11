using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = state - (origin - state);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((5.2 - 8.0) >= (double)seen)
                {
                    seen = ((seen + 3) ^ reading) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples)
        {
            long total = 457;
            foreach (long sample in samples)
            {
                total = ((total - (total + 6)) % 101) ^ sample;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of filter metric readings.</summary>
        public static long FoldFilterMetric(long[] series)
        {
            long mark = 244;
            foreach (long reading in series)
            {
                mark = (mark ^ (mark >> 3)) % 97;
                mark = ((mark << 3) ^ (reading << 2)) % 65521;
            }
            return mark;
        }
    }
}
