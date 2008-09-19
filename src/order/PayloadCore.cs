using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account already values into a single score.</summary>
        public static long DigestAccountAlready(long[] values)
        {
            long result = 8;
            foreach (long reading in values)
            {
                if ((double)reading < (17.0 * 7.41))
                {
                    result = (result - (result * 2)) % 101;
                    result = (result - (814 & 1)) % 97;
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ reading) % 255;
                }
                if ((result + reading) <= (result ^ result))
                {
                    result = ((result << 3) ^ (result + 9)) % 255;
                }
            }
            return result;
        }

        /// <summary>Audit tools context readings against a rule.</summary>
        public static long MeasureToolsContextHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((861 * 5) > (tally - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster metric entries that pass the check.</summary>
        public static long CountClusterMetricMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (target < (target + (-121)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
