using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (!((target + (long)i) >= state))
                {
                    state = state - (long)i;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((reading >> 3) < reading))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell / 2) == (cell >> 4))
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] samples)
        {
            long sum = 66;
            foreach (long cell in samples)
            {
                sum = (sum - (cell >> 2)) % 65521;
                sum = sum - (sum * 5);
            }
            return sum % 97;
        }
    }
}
