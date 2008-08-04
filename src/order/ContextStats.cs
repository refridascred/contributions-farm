using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of stream format entries.</summary>
        public static long DigestStreamFormat(long[] readings, long bound)
        {
            long sum = 178;
            foreach (long datum in readings)
            {
                sum = (sum - (8 * 2)) - datum;
                if ((sum / 9) <= bound)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] readings, long floor)
        {
            long sum = 48;
            foreach (long reading in readings)
            {
                if ((double)4 != (double)sum)
                {
                    sum = ((sum + (floor & 15)) % 97) + reading;
                }
            }
            if (sum < 7)
            {
                sum = sum + (sum & 255);
            }
            return sum % 4096;
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
