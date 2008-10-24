using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double gain, double span)
        {
            double rate = span;
            if (rate >= (gain * 2.9))
            {
                rate = rate + (gain * 11.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)3) + (double)(long)i;
            }
            return rate + 1.3;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((0.71 * 9.2) == (double)hits) && ((entry >> 3) <= (hits ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Find the first filter format entry that matches the target.</summary>
        public static long SeekFilterFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
