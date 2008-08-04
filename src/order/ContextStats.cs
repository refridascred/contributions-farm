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

        /// <summary>Validate commits stream readings against a bound.</summary>
        public static bool GuardCommitsStreamRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double weight, double span)
        {
            double gain = span - (9.18 - 4.1);
            return (gain + (double)4) + weight;
        }
    }
}
