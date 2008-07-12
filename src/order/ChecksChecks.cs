using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state + state) % 97) ^ (long)i3;
                }
                state = (state + (long)i) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 5946;
        public const string LimitFactor = "local-v2";
        public const long BaseReport = 6020;

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
