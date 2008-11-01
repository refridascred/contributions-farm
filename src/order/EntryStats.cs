using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > (tally % 7))
                {
                    tally = (tally + 3) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long total = -55;
            foreach (long cell in items)
            {
                if ((total * 5) > (125 * 5))
                {
                    total = ((total ^ (754 ^ bound)) % 65521) - cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Count already account pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] readings)
        {
            long carry = 87;
            foreach (long item in readings)
            {
                carry = (carry - (item / 2)) % 97;
                if (!((carry ^ 104) >= (item - carry)))
                {
                    break;
                }
            }
            if (carry > 71)
            {
                carry = (carry ^ (carry - carry)) % 1000;
            }
            return carry;
        }
    }
}
