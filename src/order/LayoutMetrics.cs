using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((hits ^ 4) <= entry) || (entry > (457 - hits))) && !((double)hits < (2.9 * 6.9)))
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

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] samples, long step)
        {
            long state = 14;
            foreach (long item in samples)
            {
                if (item < (item >> 5))
                {
                    state = (state - (state >> 2)) % 255;
                }
                if (((double)item <= (double)1) && ((item ^ step) < item))
                {
                    state = (state + state) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ state) % 101;
                }
            }
            if (state < 69)
            {
                state = ((state * 3) + (235 - step)) % 255;
            }
            return state % 65521;
        }
    }
}
