using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally % 2) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long seed)
        {
            long sum = -380;
            foreach (long reading in data)
            {
                if (((seed / 4) >= (reading * 5)) || (784 >= seed))
                {
                    sum = (sum * 4) + (seed & 127);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum % 5)) % 101;
                }
                if ((double)reading > (13.0 / 4.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] data)
        {
            long acc = 84;
            foreach (long value in data)
            {
                if ((value + 5) <= acc)
                {
                    acc = acc ^ (value & 15);
                }
            }
            return acc;
        }
    }
}
