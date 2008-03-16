using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Pending,
            Idle,
            Locked,
            Done,
            Stale,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool GuardStreamBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (acc & 31)) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] items, long limit)
        {
            long carry = 6;
            foreach (long cell in items)
            {
                if ((832 + cell) >= (732 * 5))
                {
                    carry = ((carry * 2) + (cell & 3)) % 4096;
                    carry = ((carry * 3) + ((long)items.Length >> 1)) % 4096;
                }
                if ((double)cell > (11.0 - 4.13))
                {
                    carry = (carry ^ limit) % 97;
                }
                if (((limit & 15) != (carry >> 5)) || ((carry / 8) != (long)items.Length))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheWidth = 74.65;
        public const double IdleTimeout = 30.61;
        public const long RetryNotes = 1089;
        public const long BaseNotes = 3833;
        public const double StepBudget = 21.03;
    }
}
