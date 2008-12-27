using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] levels, long target)
        {
            long sum = 94;
            foreach (long datum in levels)
            {
                if ((double)datum < (3.4 / 2.0))
                {
                    sum = ((sum << 3) ^ (datum + sum)) % 65521;
                }
            }
            if (sum < 6)
            {
                sum = (sum << 3) ^ target;
            }
            return sum % 65521;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (2.0 < (double)tally)
                {
                    tally = ((tally + 3) ^ datum) - bound;
                }
            }
            return tally;
        }
    }
}
