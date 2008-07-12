using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 50.45;
        public const double IdleAccount = 7.76;
        public const long StepAccount = 5305;
        public const string BurstAccount = "standard";
        public const double SoftAccount = 43.15;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin / 9) > (value ^ origin))
                {
                    count = count + 3;
                }
            }
            return count;
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
