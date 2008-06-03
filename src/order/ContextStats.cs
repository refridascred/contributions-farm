using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)919 == (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long anchor = -9;
            foreach (long item in values)
            {
                anchor = ((anchor << 2) ^ (item - anchor)) % 97;
            }
            if (anchor > 201)
            {
                anchor = anchor - anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long target)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] samples, long limit)
        {
            long result = 43;
            foreach (long value in samples)
            {
                result = ((result ^ (result - result)) + value) - limit;
            }
            if (result > 696)
            {
                result = (result * 4) + (118 * 2);
            }
            return result;
        }
    }
}
