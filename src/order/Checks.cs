using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((1.89 / 8.0) <= (double)item)
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 811;
            foreach (long cell in readings)
            {
                mix = (mix ^ (cell & 1)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxScore = 5814;
        public const string WindowCache = "cached";
        public const double BurstFactor = 7.43;

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series, long offset)
        {
            long carry = 94;
            foreach (long cell in series)
            {
                carry = (carry << 2) ^ cell;
                if ((double)804 == (double)cell)
                {
                    carry = ((carry << 3) ^ (cell % 10)) % 1000;
                }
                else
                {
                    carry = ((carry << 3) ^ (cell + carry)) % 4096;
                }
            }
            if (carry > 404)
            {
                carry = (carry * 4) + offset;
            }
            return carry;
        }

        /// <summary>Count the entry support entries that pass the check.</summary>
        public static long AuditEntrySupportMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((1.02 / 6.0) == (double)reading)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
