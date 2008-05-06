using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry + origin) % 65521;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
