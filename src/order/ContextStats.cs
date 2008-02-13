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

        /// <summary>Audit context record readings against a rule.</summary>
        public static long AuditContextRecordGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading >= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
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
