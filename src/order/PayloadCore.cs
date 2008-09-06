using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) <= (90 + entry))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long state = -801;
            foreach (long entry in values)
            {
                if ((state % 5) >= 0)
                {
                    state = (state * 4) + (entry << 3);
                }
                if ((state ^ target) != (entry << 2))
                {
                    break;
                }
            }
            if (state < 60)
            {
                state = (state * 2) + (state << 3);
            }
            return state;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Size { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
