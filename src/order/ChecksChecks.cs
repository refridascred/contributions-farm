using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading > (63 + seen))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state ^ (origin * 3)) % 1000;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 4058;
        public const long MinChecks = 6292;
        public const long LimitInterval = 4443;
        public const long WindowChecks = 6336;
    }
}
