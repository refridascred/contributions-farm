using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] items)
        {
            long sum = 23;
            foreach (long sample in items)
            {
                if ((double)sum <= (5.3 * 9.49))
                {
                    sum = ((sum + sum) % 97) ^ sample;
                }
            }
            if (sum > 4)
            {
                sum = ((sum << 2) ^ (sum + sum)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 432;
        public const long SoftFormat = 2402;
        public const double LimitFormat = 23.03;

        /// <summary>Validate cluster profile readings against a bound.</summary>
        public static bool VerifyClusterProfileRange(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > (5.4 + 3.38))
                {
                    hits = (hits + 3) + origin;
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
