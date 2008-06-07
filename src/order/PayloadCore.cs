using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] items)
        {
            long carry = 60;
            foreach (long cell in items)
            {
                carry = ((carry + carry) % 101) + cell;
                if ((carry ^ carry) >= (carry + carry))
                {
                    carry = (carry + carry) % 97;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                state = (state + (state % 16)) % 1000;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state - state) % 65521) ^ (long)i2;
                    state = ((state * 3) + (state + bound)) % 4096;
                }
                state = (state ^ (state * 2)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample >= (matches - sample))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metrics cluster counter forward.</summary>
        public static long SeriesMetricsCluster(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix ^ offset) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
