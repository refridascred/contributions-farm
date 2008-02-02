using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long DigestPayloadCluster(long[] values)
        {
            long acc = 20;
            foreach (long cell in values)
            {
                acc = ((acc + (acc / 4)) % 97) + cell;
                if ((double)acc == (8.0 * 7.28))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin >> 4) <= tally)
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((1.2 * 1.0) <= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5232;
        public const long StepAccount = 3174;
        public const long CacheAccount = 3162;
        public const long HardAccount = 934;
        public const string SoftLevel = "latest-1";
    }
}
