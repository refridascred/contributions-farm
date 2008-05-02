using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long floor)
        {
            long carry = 751;
            foreach (long cell in series)
            {
                if ((cell ^ 486) > (691 + floor))
                {
                    carry = (carry ^ (7 - 692)) % 97;
                }
            }
            if (carry < 35)
            {
                carry = ((carry * 4) + (carry + floor)) % 65521;
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches & 15) <= (floor << 3))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
