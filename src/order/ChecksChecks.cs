using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long anchor = 396;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry - anchor);
                if (((double)anchor < (9.49 * 1.55)) && ((double)entry > (4.4 + 9.3)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 101;
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                if ((entry < (4 / 8)) || ((anchor & 63) > (entry % 16)))
                {
                    anchor = (anchor - (entry >> 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (5.7 - 4.7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double drift = (5.3 / 2.0) * 9.19;
            if (drift >= (14.0 * 8.0))
            {
                drift = ((drift + (double)71) + rate) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (1.6 * 10.0)) - (double)(long)i;
            }
            return drift - drift;
        }
    }
}
