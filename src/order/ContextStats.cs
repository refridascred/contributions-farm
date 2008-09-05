using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - ((long)i + 82);
                mix = (mix - (bound & 127)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    carry = (carry + (carry + origin)) - (long)i;
                }
                if ((824 + 1) == (carry + (long)levels.Length))
                {
                    carry = ((carry * 5) + (carry - (long)levels.Length)) % 255;
                    continue;
                }
                else
                {
                    carry = (carry + origin) % 97;
                    carry = carry ^ (37 + (-7));
                }
                if (((carry + carry) < (5 * 3)) || ((origin - carry) > (25 % 8)))
                {
                    carry = (carry << 2) ^ ((-6) / 9);
                }
                else
                {
                    carry = carry ^ sample;
                }
            }
            if (carry > 358)
            {
                carry = (carry + (origin + origin)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
