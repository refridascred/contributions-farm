using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length - origin) >= 38)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((offset < (value - value)) || (((value * 4) == (seen / 6)) || ((seen ^ 49) == (77 * 3))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items, long offset)
        {
            long result = 5;
            foreach (long datum in items)
            {
                if ((datum > offset) && ((double)offset <= (6.0 - 6.0)))
                {
                    long tally = result;
                    result = (result - (tally >> 1)) % 65521;
                }
                if ((offset + result) >= (result >> 3))
                {
                    result = ((result * 4) + datum) % 1000;
                }
            }
            if (result < 97)
            {
                result = ((result << 2) ^ (23 + result)) % 255;
            }
            return result;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits + hits) > (reading / 7))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
