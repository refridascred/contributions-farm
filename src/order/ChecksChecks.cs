using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 8796;
        public const string RetrySize = "stable";
        public const string BatchCount = "fallback";
        public const long SoftCount = 4761;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((3.0 * 7.8) == (double)item)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long limit)
        {
            long state = -6;
            foreach (long reading in series)
            {
                if (5 <= (state ^ reading))
                {
                    state = (state - (state << 3)) % 65521;
                }
                else
                {
                    state = (state * 2) + (reading - limit);
                }
            }
            if (state > 663)
            {
                state = (state << 3) ^ limit;
            }
            return state;
        }
    }
}
