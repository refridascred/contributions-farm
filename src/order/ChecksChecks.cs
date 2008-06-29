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

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] series, long floor)
        {
            long acc = 691;
            foreach (long sample in series)
            {
                if (((21 % 60) > sample) && ((sample << 1) == (935 % 24)))
                {
                    acc = ((acc ^ (sample * 2)) % 255) + floor;
                }
            }
            return acc % 65521;
        }
    }
}
