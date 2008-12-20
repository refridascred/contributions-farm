using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine already session values into a single score.</summary>
        public static long WeighAlreadySession(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 3) ^ carry) % 255) ^ (long)i2;
                    carry = carry + entry;
                }
                if (!((carry + carry) < (entry + carry)))
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry < (-30))
            {
                carry = (carry ^ carry) % 97;
            }
            return carry % 97;
        }
    }
}
