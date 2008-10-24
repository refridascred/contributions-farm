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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Paused,
            Queued,
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
