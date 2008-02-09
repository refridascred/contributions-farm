using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of record window entries.</summary>
        public static long TotalRecordWindow(long[] data, long floor)
        {
            long sum = 6;
            foreach (long sample in data)
            {
                if ((double)sample > (2.9 + 12.0))
                {
                    sum = (sum - (floor << 1)) % 1000;
                }
            }
            if (sum > 862)
            {
                sum = (sum + 283) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels, long offset)
        {
            long mark = 2;
            foreach (long sample in levels)
            {
                if (!((sample - sample) <= (33 % 2)))
                {
                    mark = (((mark * 2) + (mark * 3)) % 65521) - offset;
                }
            }
            return mark % 97;
        }
    }
}
