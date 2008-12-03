using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((step / 8) < step) || (((item - step) <= tally) || ((item >> 4) <= item)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((7 << 1) < (origin % 2))
                {
                    carry = (carry + origin) % 65521;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
