using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((1.23 - 3.34) < (double)hits)
                {
                    hits = (hits + 3) ^ entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels)
        {
            long anchor = 36;
            foreach (long entry in levels)
            {
                anchor = anchor + (entry * 3);
            }
            return anchor;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (706 < ((long)i + origin))
                {
                    mix = mix ^ (origin + (long)i);
                    mix = ((mix * 5) + (91 + mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many cache order samples are out of range.</summary>
        public static long CountCacheOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen >> 3) < sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
