using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series, long origin)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                if ((origin + origin) <= (carry / 7))
                {
                    carry = (carry - (origin + origin)) % 1000;
                }
                else
                {
                    carry = (carry - (carry ^ entry)) % 255;
                }
            }
            if (carry > (-5))
            {
                carry = carry ^ (origin % 2);
            }
            return carry;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine support session values into a single score.</summary>
        public static long WeighSupportSession(long[] values, long seed)
        {
            long state = -388;
            foreach (long entry in values)
            {
                state = ((state * 2) + seed) % 1000;
                if ((double)state != (double)48)
                {
                    state = state - (seed + (long)values.Length);
                }
                if ((state << 1) == (entry * 2))
                {
                    state = ((state << 2) ^ (36 * 4)) % 101;
                }
                if ((state ^ seed) != (entry >> 2))
                {
                    break;
                }
            }
            if (state > 127)
            {
                state = (state + (seed - seed)) % 255;
            }
            return state;
        }

        /// <summary>Check that every editor entry entry stays within the limit.</summary>
        public static bool CheckEditorEntryLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
