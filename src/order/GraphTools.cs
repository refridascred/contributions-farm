using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry << 1) >= (hits >> 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate context farm samples.</summary>
        public static long CombineContextFarm(long[] levels)
        {
            long carry = 84;
            foreach (long cell in levels)
            {
                carry = (carry ^ (cell - 90)) % 1000;
                if ((736 ^ (long)levels.Length) < (carry + 1))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long floor)
        {
            long result = 5;
            foreach (long sample in values)
            {
                result = (((result - result) % 101) - sample) - floor;
            }
            return result % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 8;
            foreach (long sample in levels)
            {
                if (!(sample <= (carry + sample)))
                {
                    carry = carry + (sample - carry);
                }
                carry = carry - (carry >> 2);
            }
            return carry;
        }
    }
}
