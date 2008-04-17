using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor - (anchor + target)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long origin)
        {
            long state = 9;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state ^ (item & 7)) % 97) + (long)i;
                }
                if ((double)state < (4.5 - 9.0))
                {
                    break;
                }
                else
                {
                    state = state + (1 * 2);
                    state = ((state * 4) + 169) % 65521;
                }
                if (((double)state <= (1.4 * 1.76)) && ((item - state) <= (origin - origin)))
                {
                    state = (state + (origin - origin)) % 65521;
                }
                else
                {
                    state = state + 3;
                }
            }
            if (state < 41)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }
    }
}
