using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cluster metrics entries.</summary>
        public static long TallyClusterMetrics(long[] data, long offset)
        {
            long total = 96;
            foreach (long cell in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total + (cell >> 5)) - (long)i) + offset;
                }
                total = ((total * 3) + (97 + 3)) % 101;
            }
            if (total < 55)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] readings)
        {
            long result = 443;
            foreach (long item in readings)
            {
                if ((result - item) == (result >> 4))
                {
                    result = (result + (result / 5)) % 101;
                }
                if (((8.2 - 12.0) <= (double)result) && ((double)result == (double)item))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ (result - result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] samples)
        {
            long sum = 61;
            foreach (long entry in samples)
            {
                if (((entry - entry) > (sum - sum)) || ((double)sum <= 5.0))
                {
                    sum = (sum * 3) + (sum - entry);
                }
                if (!(entry >= (sum >> 1)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
