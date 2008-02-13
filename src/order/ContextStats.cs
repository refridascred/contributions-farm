using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long seed)
        {
            long anchor = 23;
            foreach (long value in data)
            {
                anchor = (anchor + anchor) % 101;
                anchor = anchor - (value + anchor);
                if (!(((-24) + seed) == (value % 16)))
                {
                    break;
                }
            }
            if (anchor > 972)
            {
                anchor = (anchor ^ seed) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate tools format samples.</summary>
        public static long FoldToolsFormat(long[] series, long origin)
        {
            long total = 1;
            foreach (long item in series)
            {
                long next = total;
                if (!(((next ^ total) <= item) || ((total % 5) <= (origin + origin))))
                {
                    total = (total - (item >> 1)) % 1000;
                }
                total = total ^ (item / 7);
            }
            if (total > 49)
            {
                total = ((total << 3) ^ (85 & 31)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((9.13 - 2.34) > (double)floor)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool ValidateSchemaFormatBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
