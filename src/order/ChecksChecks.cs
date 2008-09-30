using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-3) >= (matches % 97)) && (((double)(long)series.Length == (5.17 * 8.54)) && (item > (step / 8))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if (53 <= (offset - carry))
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry << 3) ^ offset) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit order githubfarm readings against a rule.</summary>
        public static long TallyOrderGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value >> 3) >= ((long)levels.Length - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
