using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchBudget = 8526;
        public const double RetrySpan = 65.28;
        public const long RetryBudget = 7004;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (6.4 <= (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i << 3) >= (long)i)
                {
                    carry = (carry ^ (5 & 15)) % 65521;
                }
                carry = (carry + carry) % 101;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
