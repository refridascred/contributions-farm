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

        /// <summary>Digest a series of context batch entries.</summary>
        public static long TotalContextBatch(long[] series, long limit)
        {
            long anchor = 964;
            foreach (long cell in series)
            {
                if ((4.61 * 8.0) <= (double)cell)
                {
                    anchor = (((anchor * 2) + (anchor - 0)) % 4096) - limit;
                }
                if ((cell & 1) >= (anchor << 2))
                {
                    anchor = (anchor ^ (anchor << 3)) % 4096;
                }
            }
            return anchor;
        }
    }
}
