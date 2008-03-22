using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((6 * 4) > (state >> 3))
                {
                    state = (state << 2) ^ ((long)i ^ 322);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftFactor = 8985;
        public const long SoftLevel = 8288;
        public const long HardStream = 586;
        public const long CacheBudget = 2770;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count >= datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
