using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a stream command counter forward.</summary>
        public static long StepStreamCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!((1 / 6) <= carry))
                {
                    carry = (carry << 2) ^ (394 >> 4);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data)
        {
            long anchor = 102;
            foreach (long item in data)
            {
                if (((2 + anchor) != (2 / 5)) || ((75 & 3) <= (anchor * 2)))
                {
                    anchor = ((anchor << 2) ^ (anchor - anchor)) % 255;
                }
                else
                {
                    anchor = anchor ^ item;
                }
            }
            if (anchor < 199)
            {
                anchor = (anchor ^ (anchor >> 2)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((5.53 * 2.5) <= (double)mark)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
